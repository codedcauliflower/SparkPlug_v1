using SparkPlug_v1.Data_Access;
using SparkPlug_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SparkPlug_v1.Business
{
    internal class GenerateProject
    {
        private DatabaseOperations dbOps = new DatabaseOperations();
        private StackCompatibilityRules compatibilityRules = new StackCompatibilityRules();
        private Random random = new Random();

        public Project Generate(string languageName, string appType, string complexityLevel, string styleName, string industryName)
        {
            Project project = null;

            //handle parameters
            int languageId = dbOps.SelectIdByName(languageName, "Languages", "Language", "LanguageName");
            int appTypeId = dbOps.SelectIdByName(appType, "AppTypes", "AppType", "AppType");
            int complexityId = dbOps.SelectIdByName(complexityLevel, "ComplexityLevels", "Complexity", "ComplexityLevel");
            int styleId = dbOps.SelectIdByName(styleName, "Styles", "Style", "StyleName");
            int industryId = dbOps.SelectIdByName(industryName, "Industries", "Industry", "IndustryName");

            //check compatibility
            bool isCompatible = false;

            while (isCompatible==false)
            {
                //handle randoms
                string frontendName = RandomFrontend();
                int frontendId = dbOps.SelectIdByName(frontendName, "FrontendTechnologies", "Frontend", "FrontendName");

                string backendName = RandomBackend();
                int backendId = dbOps.SelectIdByName(backendName, "BackendTechnologies", "Backend", "BackendName");

                string databaseName = RandomDatabase();
                int databaseId = dbOps.SelectIdByName(databaseName, "Databases", "Database", "DatabaseName");

                isCompatible = compatibilityRules.IsCompatible(languageName, frontendName, backendName, databaseName, appType);

                if (isCompatible == true)
                {
                    project = new Project
                    {
                        Id = 0,
                        Name = "DummyName",
                        ComplexityId = complexityId,
                        AppTypeId = appTypeId,
                        StyleId = styleId,
                        IndustryId = industryId,
                        LanguageId = languageId,
                        FrontendId = frontendId,
                        BackendId = backendId,
                        DatabaseId = databaseId
                    };

                    return project;
                }
            }

            return null;
        }

        public List<string> RandomConcepts(int complexityLevel)
        {
            Console.WriteLine($"[RandomConcepts] -> DIFFICULTY: {complexityLevel}");

            List<string> concepts = dbOps.SelectConcepts();
            List<string> resultantConcepts = new List<string>();
            HashSet<string> addedConcepts = new HashSet<string>();

            for (int i = 0; i < complexityLevel; i++)
            {
                int randomIndex;
                string randomString;

                // Keep generating random concepts until you find one that hasn't been added
                do
                {
                    randomIndex = random.Next(0, concepts.Count);
                    randomString = concepts[randomIndex];
                } while (addedConcepts.Contains(randomString));

                Console.WriteLine($"CONCEPT: {randomString}");

                resultantConcepts.Add(randomString);
                addedConcepts.Add(randomString);
            }

            Console.WriteLine($"Num of Concepts: {resultantConcepts.Count}\n");
            return resultantConcepts;
        }

        public string RandomFrontend()
        {
            Console.Write($"[RandomFrontend] -> ");

            List<string> list = dbOps.SelectFrontendTechnologies();

            int randomIndex = random.Next(0, list.Count);

            string randomString = list[randomIndex];

            Console.WriteLine($"FRONTEND: {randomString}\n");
            return randomString;
        }

        public string RandomBackend()
        {
            Console.Write("[RandomBackend] -> ");

            List<string> list = dbOps.SelectBackendTechnologies();

            int randomIndex = random.Next(0, list.Count);

            string randomString = list[randomIndex];

            Console.WriteLine($"BACKEND: {randomString}\n");
            return randomString;
        }

        public string RandomDatabase()
        {
            Console.Write("[RandomDatabase] -> ");

            List<string> list = dbOps.SelectDatabases();

            int randomIndex = random.Next(0, list.Count);

            string randomString = list[randomIndex];

            Console.WriteLine($"DATABASE: {randomString}\n");
            return randomString;
        }
    }
}

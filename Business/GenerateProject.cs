using SparkPlug_v1.Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlug_v1.Business
{
    internal class GenerateProject
    {
        private DatabaseOperations dbOps = new DatabaseOperations();
        private Random random = new Random();

        public void Generate()
        {

        }

        public string RandomConcept()
        {
            // Step 1: Retrieve the list of strings from the database
            List<string> list = dbOps.SelectConcepts();

            // Step 2: Use a random number generator to select an index
            int randomIndex = random.Next(0, list.Count);

            // Step 3: Retrieve the randomly selected string
            string randomString = list[randomIndex];

            // Step 4: Return the randomly selected string
            return randomString;
        }

        public string RandomFrontend()
        {
            // Step 1: Retrieve the list of strings from the database
            List<string> list = dbOps.SelectFrontendTechnologies();

            // Step 2: Use a random number generator to select an index
            int randomIndex = random.Next(0, list.Count);

            // Step 3: Retrieve the randomly selected string
            string randomString = list[randomIndex];

            // Step 4: Return the randomly selected string
            return randomString;
        }

        public string RandomBackend()
        {
            // Step 1: Retrieve the list of strings from the database
            List<string> list = dbOps.SelectBackendTechnologies();

            // Step 2: Use a random number generator to select an index
            int randomIndex = random.Next(0, list.Count);

            // Step 3: Retrieve the randomly selected string
            string randomString = list[randomIndex];

            // Step 4: Return the randomly selected string
            return randomString;
        }

        public string RandomDatabase()
        {
            // Step 1: Retrieve the list of strings from the database
            List<string> list = dbOps.SelectDatabases();

            // Step 2: Use a random number generator to select an index
            int randomIndex = random.Next(0, list.Count);

            // Step 3: Retrieve the randomly selected string
            string randomString = list[randomIndex];

            // Step 4: Return the randomly selected string
            return randomString;
        }
    }
}

using SparkPlug_v1.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkPlug_v1.Data_Access
{
    internal class DatabaseOperations
    {
        private string connectionString = "Server=localhost;Database=SparkPlugDB;Integrated Security=True;";

        public void CheckIf_ProjectExists()
        {

        }

        public void SelectProjects()
        {

        }

        public List<string> SelectConcepts()
        {
            List<string> concepts = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ConceptName FROM Concepts";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string concept = reader["ConceptName"].ToString();
                                concepts.Add(concept);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return concepts;
        }

        public void SelectProjectConcepts()
        {

        }

        public List<string> SelectComplexities()
        {
            List<string> complexityNames = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ComplexityLevel FROM ComplexityLevels";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string complexityName = reader["ComplexityLevel"].ToString();
                                complexityNames.Add(complexityName);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return complexityNames;
        }

        public List<string> SelectIndustries()
        {
            List<string> industryNames = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT IndustryName FROM Industries";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string industryName = reader["IndustryName"].ToString();
                                industryNames.Add(industryName);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return industryNames;
        }

        public List<string> SelectStyles()
        {
            List<string> styleNames = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT StyleName FROM Styles";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string styleName = reader["StyleName"].ToString();
                                styleNames.Add(styleName);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return styleNames;
        }

        public List<string> SelectAppTypes()
        {
            List<string> appTypes = new List<string>();

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT AppType FROM AppTypes";
                    
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                string appType = reader["AppType"].ToString();
                                appTypes.Add(appType);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return appTypes;
        }

        public List<string> SelectFrontendTechnologies()
        {
            List<string> frontends = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT FrontendName FROM FrontendTechnologies";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string frontend = reader["FrontendName"].ToString();
                                frontends.Add(frontend);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return frontends;
        }

        public List<string> SelectBackendTechnologies()
        {
            List<string> backends = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT BackendName FROM BackendTechnologies";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string backend = reader["BackendName"].ToString();
                                backends.Add(backend);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return backends;
        }

        public List<string> SelectDatabases()
        {
            List<string> databases = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT DatabaseName FROM Databases";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string database = reader["DatabaseName"].ToString();
                                databases.Add(database);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return databases;
        }

        public List<string> SelectLanguages()
        {
            List<string> languages = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT LanguageName FROM Languages";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string language = reader["LanguageName"].ToString();
                                languages.Add(language);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return languages;
        }
    }
}

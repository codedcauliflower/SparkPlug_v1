using SparkPlug_v1.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

        public void SelectConcepts()
        {

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

        public void SelectStakeholders()
        {

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

        public List<string> SelectPlatforms()
        {
            List<string> platformNames = new List<string>();

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT PlatformName FROM Platforms";
                    
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                string platformName = reader["PlatformName"].ToString();
                                platformNames.Add(platformName);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return platformNames;
        }

        public void SelectBackendTechnologies()
        {

        }

        public void SelectFrontendTechnologies()
        {

        }

        public void SelectLanguages()
        {

        }

        public void SelectStacks()
        {

        }
    }
}

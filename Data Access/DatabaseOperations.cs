using SparkPlug_v1.Business;
using SparkPlug_v1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkPlug_v1.Data_Access
{
    internal class DatabaseOperations
    {
        private string connectionString = "Server=localhost;Database=SparkPlugDB;Integrated Security=True;";

        public void InsertProject(Project project, List<string> concepts)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Projects (ProjectName, ComplexityID, AppTypeID, StyleID, IndustryID, LanguageID, FrontendID, BackendID, DatabaseID) VALUES (@Name, @ComplexityID, @AppTypeID, @StyleID, @IndustryID, @LanguageID, @FrontendID, @BackendID, @DatabaseID)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", project.Name);
                        command.Parameters.AddWithValue("@ComplexityID", project.ComplexityId);
                        command.Parameters.AddWithValue("@AppTypeID", project.AppTypeId);
                        command.Parameters.AddWithValue("@StyleID", project.StyleId);
                        command.Parameters.AddWithValue("@IndustryID", project.IndustryId);
                        command.Parameters.AddWithValue("@LanguageID", project.LanguageId);
                        command.Parameters.AddWithValue("@FrontendID", project.FrontendId);
                        command.Parameters.AddWithValue("@BackendID", project.BackendId);
                        command.Parameters.AddWithValue("@DatabaseID", project.DatabaseId);

                        command.ExecuteNonQuery();

                        Project lastProject = SelectLastProject();

                        foreach (string conceptName in concepts)
                        {
                            InsertInto_ProjectsConcepts(lastProject.Id, SelectIdByName(conceptName, "Concepts", "Concept", "ConceptName"));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }
        }

        public void UpdateProject(Project project)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // First, update the existing project
                    string query = "UPDATE Projects SET ProjectName = @Name WHERE ProjectID = @ProjectID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", project.Name);
                        command.Parameters.AddWithValue("@ProjectID", project.Id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }
        }

        public void InsertInto_ProjectsConcepts(int projectId, int conceptId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Projects_Concepts (ProjectID, ConceptID) VALUES (@ProjectID, @ConceptID)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProjectID", projectId);
                        command.Parameters.AddWithValue("@ConceptID", conceptId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }
        }

        public List<Project> SelectProjects()
        {
            List<Project> projects = new List<Project>();

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Projects";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        using(SqlDataReader  reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Project project = new Project
                                {
                                    Id = Convert.ToInt32(reader["ProjectID"]),
                                    Name = reader["ProjectName"].ToString(),
                                    ComplexityId = Convert.ToInt32(reader["ComplexityID"]),
                                    AppTypeId = Convert.ToInt32(reader["AppTypeID"]),
                                    StyleId = Convert.ToInt32(reader["StyleID"]),
                                    IndustryId = Convert.ToInt32(reader["IndustryID"]),
                                    LanguageId = Convert.ToInt32(reader["LanguageID"]),
                                    FrontendId = Convert.ToInt32(reader["FrontendID"]),
                                    BackendId = Convert.ToInt32(reader["BackendID"]),
                                    DatabaseId = Convert.ToInt32(reader["DatabaseID"])
                                };

                                projects.Add(project);
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return projects;
        }

        public DataTable SelectProjects_ReturnDataTable()
        {
            DataTable projectsDataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Projects";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(projectsDataTable);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return projectsDataTable;
        }

        public string SelectProjectNameByProjectId(int projectId)
        {
            string projectName = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ProjectName FROM Projects WHERE ProjectID=@ProjectID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProjectID", projectId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                projectName = reader["ProjectName"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return projectName;
        }

        public Project SelectLastProject()
        {
            Project lastProject = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT TOP 1 * FROM Projects ORDER BY ProjectID DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lastProject = new Project
                                {
                                    Id = Convert.ToInt32(reader["ProjectID"]),
                                    Name = reader["ProjectName"].ToString(),
                                    ComplexityId = Convert.ToInt32(reader["ComplexityID"]),
                                    AppTypeId = Convert.ToInt32(reader["AppTypeID"]),
                                    StyleId = Convert.ToInt32(reader["StyleID"]),
                                    IndustryId = Convert.ToInt32(reader["IndustryID"]),
                                    LanguageId = Convert.ToInt32(reader["LanguageID"]),
                                    FrontendId = Convert.ToInt32(reader["FrontendID"]),
                                    BackendId = Convert.ToInt32(reader["BackendID"]),
                                    DatabaseId = Convert.ToInt32(reader["DatabaseID"])
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            Console.WriteLine($"PROJECT ID: {lastProject.Id}");
            return lastProject;
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

        public List<int> SelectConceptIDsByProjectId(int projectId)
        {
            List<int> conceptIds = new List<int>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ConceptID FROM Projects_Concepts WHERE ProjectID = @ProjectID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProjectID", projectId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int conceptId = Convert.ToInt32(reader["ConceptID"]);
                                conceptIds.Add(conceptId);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return conceptIds;
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

        public int SelectIdByName(string name, string tableName, string keyword, string columnName)
        {
            int id = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT {keyword}ID FROM {tableName} WHERE {columnName}=@{keyword}Name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue($"@{keyword}Name", name);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                id = Convert.ToInt32(reader[$"{keyword}ID"]);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return id;
        }

        public string SelectNameById(int id, string tableName, string keyword, string columnName)
        {
            string name = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT {columnName} FROM {tableName} WHERE {keyword}ID=@{keyword}ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue($"@{keyword}ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                name = reader[$"{columnName}"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBoxHelper.Show(e.Message);
            }

            return name;
        }
    }
}

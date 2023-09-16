using SparkPlug_v1.Data_Access;
using SparkPlug_v1.Models;
using SparkPlug_v1.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkPlug_v1
{
    public partial class ViewProjects : Form
    {
        DatabaseOperations dbOps = new DatabaseOperations();

        private int nextProjectPanelY = 180;

        private List<Panel> projectPanels = new List<Panel>(); // Store created project panels
        private int projectsPerPage = 4; // Number of projects to display per page
        private int currentPage = 1; // Current page 
        private int totalProjects;
        private int totalPages;

        public ViewProjects()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            Home home = new Home();
            home.Show();
        }

        private void ViewProjects_Load(object sender, EventArgs e)
        {
            GlobalVariables.currentForm = this;
            DisplayProjects();
        }

        private Label CreateLabel(string text, Point location)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Text = text;
            label.Location = location;
            label.ForeColor = Color.FromArgb(184, 192, 175);
            return label;
        }

        private void CreateProjectPanel(Project project)
        {
            // Create a panel for the project
            Panel projectPanel = new Panel();
            projectPanel.Size = new System.Drawing.Size(690, 125);
            projectPanel.BorderStyle = BorderStyle.FixedSingle;
            projectPanel.Location = new System.Drawing.Point(200, nextProjectPanelY);
            projectPanel.BackColor = Color.FromArgb(82, 90, 73);

            // Create labels for project details
            Label lblId = CreateLabel("Project ID: " + project.Id, new Point(10, 10));
            Label lblName = CreateLabel("Project Name: " + project.Name, new Point(130, 10));
            Label lblComplexity = CreateLabel("Complexity: " + dbOps.SelectNameById(project.ComplexityId, "ComplexityLevels", "Complexity", "ComplexityLevel"), new Point(10, 40));
            Label lblAppType = CreateLabel("App Type: " + dbOps.SelectNameById(project.AppTypeId, "AppTypes", "AppType", "AppType"), new Point(10, 70));
            Label lblStyle = CreateLabel("Style: " + dbOps.SelectNameById(project.StyleId, "Styles", "Style", "StyleName"), new Point(130, 70));
            Label lblIndustry = CreateLabel("Industry: " + dbOps.SelectNameById(project.IndustryId, "Industries", "Industry", "IndustryName"), new Point(290, 70));
            Label lblLanguage = CreateLabel("Language: " + dbOps.SelectNameById(project.LanguageId, "Languages", "Language", "LanguageName"), new Point(10, 100));
            Label lblFrontend = CreateLabel("Frontend: " + dbOps.SelectNameById(project.FrontendId, "FrontendTechnologies", "Frontend", "FrontendName"), new Point(130, 100));
            Label lblBackend = CreateLabel("Backend: " + dbOps.SelectNameById(project.BackendId, "BackendTechnologies", "Backend", "BackendName"), new Point(290, 100));
            Label lblDatabase = CreateLabel("Database: " + dbOps.SelectNameById(project.DatabaseId, "Databases", "Database", "DatabaseName"), new Point(420, 100));

            // Create a button to view the project in another form
            Button viewButton = new Button();
            viewButton.Text = "View";
            viewButton.Location = new System.Drawing.Point(590, 50);
            viewButton.BackColor = Color.FromArgb(130, 130, 130);
            viewButton.ForeColor = Color.FromName("Snow");
            viewButton.FlatStyle = FlatStyle.Flat;
            viewButton.Click += (sender, e) =>
            {
                OpenDisplayProjectForm(project.Id);
            };

            nextProjectPanelY += projectPanel.Height + 10;

            // Add the controls to the project panel
            projectPanel.Controls.AddRange(new Control[] { lblId, lblName, lblComplexity, lblAppType, lblStyle, lblIndustry, lblLanguage, lblFrontend, lblBackend, lblDatabase, viewButton });

            // Add the project panel to the LIST
            projectPanels.Add(projectPanel);

            // Add the project panel to the FORM
            this.Controls.Add(projectPanel);
        }

        private void DisplayProjects()
        {
            DataTable projectsDataTable = dbOps.SelectProjects_ReturnDataTable();
            totalProjects = projectsDataTable.Rows.Count;
            totalPages = (int)Math.Ceiling((double)totalProjects / projectsPerPage);

            nextProjectPanelY = 180;

            // Clear existing project panels
            foreach (Panel panel in projectPanels)
            {
                this.Controls.Remove(panel);
            }
            projectPanels.Clear();


            int startIndex = (currentPage - 1) * projectsPerPage;
            int endIndex = Math.Min(startIndex + projectsPerPage, totalProjects);

            for (int i = startIndex; i < endIndex; i++)
            {
                DataRow row = projectsDataTable.Rows[i];

                CreateProjectPanel(new Project(
                    Convert.ToInt32(row["ProjectID"]),
                    row["ProjectName"].ToString(),
                    Convert.ToInt32(row["ComplexityID"]),
                    Convert.ToInt32(row["AppTypeID"]),
                    Convert.ToInt32(row["StyleID"]),
                    Convert.ToInt32(row["IndustryID"]),
                    Convert.ToInt32(row["LanguageID"]),
                    Convert.ToInt32(row["FrontendID"]),
                    Convert.ToInt32(row["BackendID"]),
                    Convert.ToInt32(row["DatabaseID"])
                ));
            }
        }

        private void OpenDisplayProjectForm(int projectId)
        {
            AssignProjectGlobalVariable(projectId);

            this.Hide();

            DisplayProject display = new DisplayProject();
            display.ShowDialog();
        }

        private void AssignProjectGlobalVariable(int projectId)
        {
            DataTable projectsDataTable = dbOps.SelectProjects_ReturnDataTable();

            Project project = new Project();

            foreach (DataRow row in projectsDataTable.Rows)
            {
                int projectID = Convert.ToInt32(row["ProjectID"]);

                if (projectID == projectId)
                {
                    project = new Project
                    {
                        Id = Convert.ToInt32(row["ProjectID"]),
                        Name = Convert.ToString(row["ProjectName"]),
                        ComplexityId = Convert.ToInt32(row["ComplexityID"]),
                        AppTypeId = Convert.ToInt32(row["AppTypeID"]),
                        StyleId = Convert.ToInt32(row["StyleID"]),
                        IndustryId = Convert.ToInt32(row["IndustryID"]),
                        LanguageId = Convert.ToInt32(row["LanguageID"]),
                        FrontendId = Convert.ToInt32(row["FrontendID"]),
                        BackendId = Convert.ToInt32(row["BackendID"]),
                        DatabaseId = Convert.ToInt32(row["DatabaseID"])

                    };
                    break;
                }
            }

            Console.WriteLine($"{project.Id}_{project.Name}");

            GlobalVariables.currentProject = project;
        }

        private void btnPreviousPanelsPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayProjects();
            }
        }

        private void btnNextPanelsPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayProjects();
            }
        }
    }
}

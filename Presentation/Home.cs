using SparkPlug_v1.Business;
using SparkPlug_v1.Data_Access;
using SparkPlug_v1.Models;
using SparkPlug_v1.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkPlug_v1
{
    public partial class Home : Form
    {
        DatabaseOperations dbOps = new DatabaseOperations();
        GenerateProject generateProject = new GenerateProject();

        public Home()
        {
            InitializeComponent();
        }

        private void RefreshDataSources()
        {
            cbxLanguage.DataSource = dbOps.SelectLanguages();
            cbxAppType.DataSource = dbOps.SelectAppTypes();
            cbxComplexity.DataSource = dbOps.SelectComplexities();
            cbxStyle.DataSource = dbOps.SelectStyles();
            cbxIndustry.DataSource = dbOps.SelectIndustries();
        }

        private void btnViewProjects_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewProjects view = new ViewProjects();
            view.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            GlobalVariables.currentForm = this;
            RefreshDataSources();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the language is HTML and the app type is DESKTOP or CONSOLE
                if (cbxLanguage.Text == "HTML" && (cbxAppType.Text == "Desktop" || cbxAppType.Text == "Console"))
                {
                    MessageBox.Show("HTML is not capable of creating such an app.\n");
                    return;
                }

                /*
                 * PROBLEM: generating a new project, but there are no projects in database, so we do not have a ProjectID for the project
                 * SOLUTION: give the project a dummy ID, proceed to insert a project then get the ProjectID of the inserted project, and lastly give the project a new ID
                 * 
                 * PROBLEM: we need unique names for generated projects, but the only unique thing about a project is it's ProjectID, which is only added later
                 * SOLUTION: quite simple really, just add a name when we get the ID
                 */

                Models.Project project = generateProject.Generate(cbxLanguage.Text, cbxAppType.Text, cbxComplexity.Text, cbxStyle.Text, cbxIndustry.Text);

                if (project != null)
                {
                    string complexityLevel = cbxComplexity.Text;
                    int complexityId = dbOps.SelectIdByName(complexityLevel, "ComplexityLevels", "Complexity", "ComplexityLevel");
                    List<string> randomConcepts = generateProject.RandomConcepts(complexityId);

                    dbOps.InsertProject(project, randomConcepts);
                    project.Id = dbOps.SelectLastProject().Id;
                    project.Name = $"{cbxLanguage.Text}_{cbxIndustry.Text}{cbxAppType.Text}App";

                    dbOps.UpdateProject(project);

                    GlobalVariables.currentProject = project;

                    this.Hide();

                    DisplayProject displayProject = new DisplayProject();
                    displayProject.Show();
                }
                else
                {
                    MessageBox.Show("Project returned null.");
                }
            }
            catch(Exception ex)
            {
                MessageBoxHelper.Show(ex.Message);
            }
        }
    }
}

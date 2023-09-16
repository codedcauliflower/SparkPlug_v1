using SparkPlug_v1.Data_Access;
using SparkPlug_v1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkPlug_v1.Presentation
{
    public partial class DisplayProject : Form
    {
        DatabaseOperations dbOps = new DatabaseOperations();

        public DisplayProject()
        {
            InitializeComponent();
        }

        private void DisplayProject_Load(object sender, EventArgs e)
        {
            Project project = GlobalVariables.currentProject;

            lblProjectID.Text = project.Id.ToString();
            lblProjectName.Text = project.Name;

            lblProjectLanguage.Text = dbOps.SelectNameById(project.LanguageId, "Languages", "Language", "LanguageName");
            lblProjectFrontend.Text = dbOps.SelectNameById(project.FrontendId, "FrontendTechnologies", "Frontend", "FrontendName");
            lblProjectBackend.Text = dbOps.SelectNameById(project.BackendId, "BackendTechnologies", "Backend", "BackendName");
            lblProjectDatabase.Text = dbOps.SelectNameById(project.DatabaseId, "Databases", "Database", "DatabaseName");
            lblProjectAppType.Text = dbOps.SelectNameById(project.AppTypeId, "AppTypes", "AppType", "AppType");
            lblProjectIndustry.Text = dbOps.SelectNameById(project.IndustryId, "Industries", "Industry", "IndustryName");
            lblProjectComplexityLevel.Text = dbOps.SelectNameById(project.ComplexityId, "ComplexityLevels", "Complexity", "ComplexityLevel");
            lblProjectStyle.Text = dbOps.SelectNameById(project.StyleId, "Styles", "Style", "StyleName");

            MakeConceptLabelsInvisible();

            //retrieve conceptIDs and then use loop to iterate accross concept labels and conceptIDs
            List<int> conceptIDs = dbOps.SelectConceptIDsByProjectId(project.Id);

            for (int i = 0; i < project.ComplexityId; i++)
            {
                //find label
                Control[] foundLabels = this.Controls.Find($"lblProjectConcept{i + 1}", true);

                // Check if the control was found
                if (foundLabels.Length > 0)
                {
                    // Access the found control
                    Control foundLabel = foundLabels[0];
                    Console.WriteLine($"[DisplayProjects] -> TEXT: {foundLabel.Text}");
                    foundLabel.Visible = true;
                    foundLabel.Text = dbOps.SelectNameById(conceptIDs[i], "Concepts", "Concept", "ConceptName");
                }
            }
        }

        private void MakeConceptLabelsInvisible()
        {
            lblProjectConcept1.Visible = false;
            lblProjectConcept2.Visible = false;
            lblProjectConcept3.Visible = false;
            lblProjectConcept4.Visible = false;
            lblProjectConcept5.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            GlobalVariables.currentForm.Show();
        }
    }
}

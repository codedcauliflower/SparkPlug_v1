using SparkPlug_v1.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkPlug_v1
{
    public partial class Home : Form
    {
        DatabaseOperations dbOps = new DatabaseOperations();

        public Home()
        {
            InitializeComponent();
        }

        private void RefreshDataSources()
        {
            cbxPlatform.DataSource = dbOps.SelectPlatforms();
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
            RefreshDataSources();
        }
    }
}

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
    public partial class ViewProjects : Form
    {
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
    }
}

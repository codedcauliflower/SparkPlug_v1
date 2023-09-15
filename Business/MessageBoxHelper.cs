using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlug_v1.Business
{
    internal static class MessageBoxHelper
    {
        public static void Show(string message)
        {
            string methodName = new StackTrace().GetFrame(1).GetMethod().Name;
            MessageBox.Show($"An error occurred while running {methodName}(): {message}");
        }
    }
}

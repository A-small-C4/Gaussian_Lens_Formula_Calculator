using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

//https://github.com/A-small-C4/Gaussian_Lens_Formula_Calculator

namespace Gaussian_Lens_Formula_Calculator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

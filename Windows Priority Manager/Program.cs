using System;
using System.Windows.Forms;

namespace Windows11PriorityManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create the main form.
            Application.Run(new Form1());
        }
    }
}

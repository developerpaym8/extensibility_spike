// <copyright file="Program.cs" company="PayM8">
//     Copyright ©  2016
// </copyright>
namespace FormsHost
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Class Program.
    /// </summary>
    static class Program
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

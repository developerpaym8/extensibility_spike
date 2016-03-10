// <copyright file="Program.cs" company="PayM8">
//     Copyright ©  2016
// </copyright>
namespace ExtensibilitySpike
{
    using System;

    /// <summary>
    /// Class Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="Program"/> class from being created.
        /// </summary>
        private Program()
        {
        }

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            var host = new Host();
            Console.WriteLine("Starting Host");
            foreach (var scheduler in host.Schedulers)
            {
                var name = scheduler.Name;
                var hostname = scheduler.GetHostName();
                Console.WriteLine("{0} is hosted in {1}", name, hostname);
            }
            Console.ReadLine();
        }
    }
}

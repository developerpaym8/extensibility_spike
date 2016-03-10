// <copyright file="Scheduler.cs" company="PayM8">
//     Copyright ©  2016
// </copyright>
namespace OneDayScheduler
{
    using Contracts;
    using SchedulerStuff;
    using System.ComponentModel.Composition;
    using System.Reflection;

    /// <summary>
    /// Class Scheduler.
    /// </summary>
    [Export(typeof(ISchedulerContract))]
    public class Scheduler : AbstractScheduler, ISchedulerContract
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Scheduler"/> class.
        /// </summary>
        public Scheduler()
            : base()
        {
        }

        /// <summary>
        /// Stops this instance.
        /// </summary>
        /// <returns><c>true</c> if running, <c>false</c> otherwise.</returns>
        public bool Stop()
        {
            StopTimer();
            return isRunning;
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        /// <returns><c>true</c> if running, <c>false</c> otherwise.</returns>
        public bool Start()
        {
            StartTimer(5000);
            return isRunning;
        }

        /// <summary>
        /// Echoes the specified text.
        /// </summary>
        /// <param name="text">The text to echo.</param>
        /// <returns>Echoed text.</returns>
        public string Echo(string text)
        {
            text += " " + this.counter;
            return text;
        }

        /// <summary>
        /// Gets the name of the host.
        /// </summary>
        /// <returns>Host name.</returns>
        public string GetHostName()
        {
            return Assembly.GetEntryAssembly().FullName;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get
            {
                return "OneDayScheduler";
            }
        }
    }
}

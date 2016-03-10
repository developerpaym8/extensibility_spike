// <copyright file="AbstractScheduler.cs" company="PayM8">
//     Copyright ©  2016
// </copyright>
namespace SchedulerStuff
{
    /// <summary>
    /// Class Abstract Scheduler.
    /// </summary>
    public abstract class AbstractScheduler
    {
        /// <summary>
        /// The timer.
        /// </summary>
        private System.Timers.Timer timer = new System.Timers.Timer(2000);

        /// <summary>
        /// The is running flag.
        /// </summary>
        public bool isRunning;

        /// <summary>
        /// The counter.
        /// </summary>
        public int counter;

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractScheduler"/> class.
        /// </summary>
        public AbstractScheduler()
        {
            this.timer.Elapsed += this.timer_Elapsed;
        }

        /// <summary>
        /// Handles the Elapsed event of the timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Timers.ElapsedEventArgs"/> instance containing the event data.</param>
        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.counter++;
        }

        /// <summary>
        /// Starts the timer.
        /// </summary>
        /// <param name="interval">The interval.</param>
        public void StartTimer(int interval)
        {
            this.counter = 0;
            this.isRunning = true;
            this.timer.Interval = interval;
            this.timer.Start();
        }

        /// <summary>
        /// Stops the timer.
        /// </summary>
        public void StopTimer()
        {
            this.isRunning = false;
            this.timer.Stop();
        }
    }
}

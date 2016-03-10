// <copyright file="ISchedulerContract.cs" company="PayM8">
//     Copyright ©  2016
// </copyright>
namespace Contracts
{
    /// <summary>
    /// Interface Scheduler Contract.
    /// </summary>
    public interface ISchedulerContract
    {
        /// <summary>
        /// Stops this instance.
        /// </summary>
        /// <returns><c>true</c> if running, <c>false</c> otherwise.</returns>
        bool Stop();

        /// <summary>
        /// Starts this instance.
        /// </summary>
        /// <returns><c>true</c> if running, <c>false</c> otherwise.</returns>
        bool Start();

        /// <summary>
        /// Echoes the specified text.
        /// </summary>
        /// <param name="text">The text to echo.</param>
        /// <returns>The echoed text.</returns>
        string Echo(string text);

        /// <summary>
        /// Gets the name of the host.
        /// </summary>
        /// <returns>The host name.</returns>
        string GetHostName();

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }
    }
}

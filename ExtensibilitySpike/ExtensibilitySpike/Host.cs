// <copyright file="Host.cs" company="PayM8">
//     Copyright ©  2016
// </copyright>
namespace ExtensibilitySpike
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;
    using Contracts;

    /// <summary>
    /// Class Host.
    /// </summary>
    public class Host
    {
        /// <summary>
        /// The schedulers.
        /// </summary>
        [ImportMany(typeof(ISchedulerContract))]
        public IEnumerable<ISchedulerContract> schedulers;

        /// <summary>
        /// The container.
        /// </summary>
        private readonly CompositionContainer container;

        /// <summary>
        /// Initializes a new instance of the <see cref="Host"/> class.
        /// </summary>
        public Host()
        {
            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(Environment.CurrentDirectory));
            this.container = new CompositionContainer(catalog);

            try
            {
                this.container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Gets the schedulers.
        /// </summary>
        /// <value>The schedulers.</value>
        public IEnumerable<ISchedulerContract> Schedulers
        {
            get
            {
                return this.schedulers;
            }
        }
    }
}

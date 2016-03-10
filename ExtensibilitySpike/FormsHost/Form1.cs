// <copyright file="Form1.cs" company="PayM8">
//     Copyright ©  2016
// </copyright>
namespace FormsHost
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Class Form1.
    /// </summary>
    public partial class Form1 : Form
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
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
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
        /// Handles the Load event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var scheduler in schedulers)
            {
                var name = scheduler.Name;
                var hostname = scheduler.GetHostName();
                this.listBox1.Items.Add(string.Format("{0}:{1}", name, hostname));
            }
        }

        /// <summary>
        /// Handles the DoubleClick event of the listBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                var itemText = this.listBox1.SelectedItem.ToString();
                var parts = itemText.Split(':');
                var schedule = schedulers.Single(s => s.Name == parts[0]);
                MessageBox.Show(schedule.Echo("Elapsed ticks"));
            }
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            var itemText = this.listBox1.SelectedItem.ToString();
            var parts = itemText.Split(':');
            var schedule = schedulers.Single(s => s.Name == parts[0]);
            schedule.Start();
        }

        /// <summary>
        /// Handles the Click event of the button2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            var itemText = this.listBox1.SelectedItem.ToString();
            var parts = itemText.Split(':');
            var schedule = schedulers.Single(s => s.Name == parts[0]);
            schedule.Stop();
        }
    }
}

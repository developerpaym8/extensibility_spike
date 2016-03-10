using Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel.Composition;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Provider
{
    [Export(typeof(ISchedulerContract))]
    public class ReconDayScheduler : ISchedulerContract
    {
        public bool Stop()
        {
            return true;
        }

        public bool Start()
        {
            return true;
        }

        public string Echo(string text)
        {
            return text;
        }

        public string GetHostName()
        {
            return Assembly.GetEntryAssembly().FullName;
        }
        public string Name()
        {
            return "ReconDayScheduler";
        }
    }

    [Export(typeof(ISchedulerContract))]
    public class OneDayScheduler : ISchedulerContract
    {
        public bool Stop()
        {
            return true;
        }

        public bool Start()
        {
            return true;
        }

        public string Echo(string text)
        {
            return text;
        }

        public string GetHostName()
        {
            return Assembly.GetEntryAssembly().FullName;
        }

        public string Name()
        {
            return "OneDayScheduler";
        }
    }

    [Export(typeof(ISchedulerContract))]
    public class TwoDayScheduler : ISchedulerContract
    {
        public bool Stop()
        {
            return true;
        }

        public bool Start()
        {
            return true;
        }

        public string Echo(string text)
        {
            return text;
        }

        public string GetHostName()
        {
            return Assembly.GetEntryAssembly().FullName;
        }


        public string Name()
        {
            return "TwoDayScheduler";
        }
    }
}

using System;
using Xamarin.Forms;
using InstabugDependencyService.Services;
using InstabugDependencyService.UWP;


[assembly: Dependency(typeof(BugReporterUWP))]
namespace InstabugDependencyService.UWP
{
    public class BugReporterUWP : IBugReporter
    {
        public void Trigger()
        {
            // UWP doesn't have bug reporting
        }
    }
}

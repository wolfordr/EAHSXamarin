using System;
using Xamarin.Forms;
using InstabugDependencyService.Services;
using InstabugDependencyService.Android;
using Com.Instabug.Bug;

[assembly: Dependency(typeof(BugReporterDroid))]
namespace InstabugDependencyService.Android
{
    public class BugReporterDroid : IBugReporter
    {
        public void Trigger()
        {
            BugReporting.Invoke();
        }
    }
}

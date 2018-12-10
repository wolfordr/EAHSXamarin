using System;
using Xamarin.Forms;
using InstabugDependencyService.Services;
using InstabugDependencyService.iOS;
using InstabugLib;

[assembly: Dependency(typeof(BugReporterIOS))]
namespace InstabugDependencyService.iOS
{
    public class BugReporterIOS : IBugReporter
    {
        public void Trigger()
        {
            IBGBugReporting.Invoke();
        }
    }
}

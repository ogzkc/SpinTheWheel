using System.Reflection;

namespace SpinTheWheel.Utility
{
    public class VersionHelper
    {
        public static string GetVersionString()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            return version.Major + "." + version.Minor + "." + version.Build;
        }
    }
}

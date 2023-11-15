using System;

namespace Api.Kashilog.Tests {
    internal class EnvironmentInfo {
        internal static bool IsCiTestEnvironment =>
            Environment.GetEnvironmentVariable("TEST_ENVIRONMENT") == "Ci";

        internal static string AppSettingsFileName =>
            IsCiTestEnvironment ? "appsettings.Ci.json" : "appsettings.Test.json";
    }
}

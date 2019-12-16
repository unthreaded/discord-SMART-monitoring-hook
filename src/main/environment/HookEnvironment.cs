using System;
namespace discord_SMART_monitoring_hook_tests
{
    public class HookEnvironment
    {
        public const string DISCORD_URL = "DISCORD_URL";

        public HookEnvironment()
        {
            String val = Environment.GetEnvironmentVariable(DISCORD_URL);
            if (val == null)
                throw new Exception(DISCORD_URL + " not set");
        }
    }
}
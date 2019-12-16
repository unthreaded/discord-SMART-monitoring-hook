using Xunit;

using System;


namespace discord_SMART_monitoring_hook_tests
{
    public class HookEnvironmentTest
    {
        [Fact]
        public void givenMissingDiscordURL_whenEnvironmentCreated_thenExceptionIsThrown()
        {
            Environment.SetEnvironmentVariable(HookEnvironment.DISCORD_URL, null);
            
            Exception exception = Assert.Throws<Exception>( () =>
                new HookEnvironment());

            Assert.NotNull(exception);
        }
    }
}
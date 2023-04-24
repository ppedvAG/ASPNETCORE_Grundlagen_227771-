namespace DefaultASPNETCoreRazorPage.Environments
{
    public static class CustomEnvironmentInstance
    {
        public static bool IsSpezialInstance(this IHostEnvironment hostEnvironment)
        {
            

            return hostEnvironment.IsEnvironment("Special");
        }
    }
}

namespace Service.API
{
    /// <summary>
    /// services for getting startup and doc generating info
    /// </summary>
    public static class StartupServices
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetApiXMLDirectory() => $"{System.AppDomain.CurrentDomain.BaseDirectory}\\bin\\SantaAPI.xml";

    }
}

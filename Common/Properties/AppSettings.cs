using System;
using System.Configuration;

namespace Common
{
    public class AppSettings
    {
        public static string ApiUrl { get => ConfigurationManager.AppSettings.Get("ApiUrl"); }
        public static string Token { get => ConfigurationManager.AppSettings.Get("Token"); }
        public static string units { get => ConfigurationManager.AppSettings.Get("Units"); }
    }
}

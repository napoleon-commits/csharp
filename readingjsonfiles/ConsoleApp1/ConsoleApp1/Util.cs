using System;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp1
{
    class Util
    {
        public static string[] getIConfigStringArray(IConfiguration configuration, string key)
        {
            string[] arr = { };
            IConfigurationSection mySections = configuration.GetSection(key);
            foreach (IConfigurationSection section in mySections.GetChildren())
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = section.Value;
            }
            return arr;
        }
    }
}

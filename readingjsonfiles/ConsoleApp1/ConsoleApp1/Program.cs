using System;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();
            Console.WriteLine("Hello {0}!", _configuration["name"]);
            string[] allowedFileTypes = { };
            IConfigurationSection mySections = _configuration.GetSection("IndexFileTypes");
            foreach(IConfigurationSection section in mySections.GetChildren())
            {
                Array.Resize(ref allowedFileTypes, allowedFileTypes.Length + 1);
                allowedFileTypes[allowedFileTypes.Length - 1] = section.Value;
            }

            foreach(var item in allowedFileTypes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

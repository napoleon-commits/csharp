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
            IConfigurationSection mySections = _configuration.GetSection("IndexFileTypes");
            foreach(IConfigurationSection section in mySections.GetChildren())
            {
                Console.WriteLine(section.Value);
            }
        }
    }
}

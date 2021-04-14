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
            string[] allowedFileTypes = Util.getIConfigStringArray(_configuration, "IndexFileTypes");
            foreach(var item in allowedFileTypes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

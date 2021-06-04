using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ldbtestcctEntities();
            var xmlConfig = new xml_config();
            context.xml_config.Add(xmlConfig);
            context.SaveChanges();
        }
    }
}

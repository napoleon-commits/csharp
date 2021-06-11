using System;
using System.Xml;

namespace xpath
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                string path = "C:\\xmls\\foo.xml";
                doc.Load(path);
                var result = doc.SelectNodes("/note/to");
                foreach (XmlNode node in result)
                {
                    Console.WriteLine(node.InnerText);
                }
                result = doc.SelectNodes("/note[to='Tove']/to");
                foreach (XmlNode node in result)
                {
                    Console.WriteLine(node.InnerText);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.ToString());
            };
        }
    }
}

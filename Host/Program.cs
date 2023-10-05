using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(LocalChatWithDB.WCFservice)))
            {
                host.Open();
                Console.WriteLine("Хост начал работу");
                Console.ReadLine();
            }
        }
    }
}

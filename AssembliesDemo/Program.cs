using System;
using Ecombiz;
using EcomBizPublic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembliesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This is a Assemblies Demo App");
            Console.ReadLine();
            Class1 ecombizLogic = new Class1();
            Console.WriteLine(ecombizLogic.GetComName());

            EcomBizPublicLogic ecomBizPublicLogic = new EcomBizPublicLogic();
            Console.WriteLine(ecomBizPublicLogic.ComName());
            Console.ReadLine();

        }

    }
}

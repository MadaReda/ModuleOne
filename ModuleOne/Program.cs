using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Mohamed";
            string lName = "Reda";
            DateTime birthDate = new DateTime(1988,6,22);
            string addressL1 = "Beni suef";
            string addressL2 = "Helwan";
            string city = "Cairo";
            int zipcode = 00000;
            string country = "Egypt";

            Console.WriteLine(fName+" "+lName);
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "krjd";
            if (str.CheckNumber())
            {
                Console.WriteLine("positive number");
            }
            else
            {
                Console.WriteLine("not positive number");
            }
        }
    }
}

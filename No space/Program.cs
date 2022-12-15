using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace No_space
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Dez.txt");

            while (true)
            {
                sw.WriteLine("Dez Nuts!");
            }
        }
    }
}

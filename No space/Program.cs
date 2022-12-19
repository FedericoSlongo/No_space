using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading;

namespace No_space
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thr1 = new Thread(The_Writer);
            Thread thr2 = new Thread(The_Writer_THE_RETURN);
            Thread thr3 = new Thread(No);
            thr1.Start();
            thr2.Start();
            thr3.Start();
        }

        public static void The_Writer()
        {
            StreamWriter sw = new StreamWriter("Dez.txt");

            while (true)
            {
                sw.WriteLine("Dez ");
            }
        }

        public static void The_Writer_THE_RETURN()
        {
            StreamWriter sw = new StreamWriter("Nuts.txt");

            while (true)
            {
                sw.WriteLine("Nuts!");
            }
        }

        public static void No()
        {
            StreamWriter sw = new StreamWriter("I_am_a_cat.txt");

            while (true)
            {
                sw.WriteLine("Miao");
            }
        }
    }
}

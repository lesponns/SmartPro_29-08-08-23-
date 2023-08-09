using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_29_08_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] lotos = new int[5];

            lotos[0] = 14;
            lotos[1] = 212;
            lotos[2] = 962;
            lotos[3] = 74;
            lotos[4] = 53;

            foreach(int i in lotos)
            {
                Console.WriteLine("Loto : {0}",i);
            }
            */

            int[] sayilar = new int[5];

            for (int i = 0; i < sayilar.Length; i++)
            { 
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in sayilar) 
            {
                Console.WriteLine("Variable: {0}", i);
            }














            Console.ReadKey();
        }
    }
}

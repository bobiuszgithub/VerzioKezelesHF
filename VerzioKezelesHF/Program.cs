using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            int db = 0;
            Console.WriteLine("Mekkora legyen a tömb hossza?");
            db = Convert.ToInt32(Console.ReadLine());

            int[] szamok = new int[db];
          
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine("add meg {0}. számot ", i+1);
                szamok[i] = Convert.ToInt32(Console.ReadLine());
            }

            //számok átlaga
            int ossz = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                ossz += szamok[i];

            }
            Console.WriteLine("A számok átlaga: {0}",ossz/szamok.Length);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            int[] yaslar = new int[10];
            string[] sehirler = new string[12];
            byte[] sayilar = new byte[3];
            char[] harfler = new char[145];


            //  Dizilere değer atarken index numaralarından faydalanılır.
            int[] test = new int[3];
            test[0] = 1;
            test[2] = 1;
            //test[20] = 1;

            Console.WriteLine(test[0]);

            string[] sehirler2 = new string[12];

            sehirler2[0] = "a";
            sehirler2[1] = "b";
            sehirler2[2] = "c";
            sehirler2[3] = "d";

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(sehirler2[i]);
            }

            int a = 0;
            while (a<10)
            {
                Console.WriteLine(sehirler2[a]);
                a += 1;
            }
            for (int i = 0; i < sehirler2.Length; i++)
            {
                Console.WriteLine(sehirler2[i]);
            }

            int[] test3 = new int[3] {1,2,3};
        }
    }
}

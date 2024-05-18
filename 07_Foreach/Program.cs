using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                   - FOREACH NEDİR ?  -
                       FOREACH DÖNGÜ DEĞİLDİR!
                       Elimizde var olan veri kümesinin üzerinde tek tek gezen iterasyon yapılanmasıdır.
                       
                   - FOREACH & DÖNGÜ FARKI -
                      Döngüleri kullanabilmemiz için elimizde bir veri kümesi olması şart değildir. Fakat foreach yapısı gereği bir veri kümesine ihtiyaç duyar.
                      Döngülerde işlem adımlarını biz belirleyebiliriz fakat foreach baştan sona tüm adımları gerçekleştirir.
                   
             */

            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
                    //değişken veri kümesi
            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }
        }
    }
}

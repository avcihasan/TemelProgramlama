using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {          

            #region for
            //     başlangıç değeri atama    şart tanımı        başlangıç değeri arttrıma azaltma
            //for (int i = 0;                i < 10;            i++)
            //{

            //}

            for(int _i = 0; _i < 10; _i = _i + 1)
            {
            }
            for (int _i = 10; _i > 0; _i = _i - 1)
            {
                Console.WriteLine(_i);
            }

            #endregion

            #region while
            // şart doğru oldukça tetiklenir . genellikle sonsuz döngü ve adım sayısı belli olmayan döngülerde kullanılır
            //while (true)
            //{

            //}
            int i = 0;
            while (i <10)
            {
                i++;
            }
      
            #endregion

            #region do while
            // while den farkı while önce şarta bakar sonra işlem yapar do while ise önce iş yapar sonra şarta bakar
            // while hiç çalışmayabilir ama dowhile en az bir kere çalışır

            do
            {
                Console.WriteLine("test");
            } while (10>50);

            while (10 > 50)
            {
                Console.WriteLine("test");
            }
            //continue;
            //break;

            #endregion

            #region sonsuz döngü

            //while (true)
            //{

            //}
            //for (; ; )
            //{

            //}

            #endregion
         
            Console.Read();
        }
    }
}

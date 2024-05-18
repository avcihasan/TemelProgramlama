using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metotlar
{
    internal class Program
    {
        //metot türleri
        public void Metot1()
        {

        }
        public void Metot2(int parametre)
        {

        }
        public int Metot3()
        {

            return 0;
        }
        private int Metot4(int parametre)
        {
            // tetiklendiği yerde fonksiyonu bitirir ve değeri döndürür
            return 0;
        }
        //metotdan dönen değer çağrıldığı yerde yakalanıo kullanılabilir
        public static int Topla(int a,int b )
        {
            int topla = a + b;
            //Console.WriteLine(  );
            return topla;
        }
        static void Main(string[] args)
        {

            /*
           - METOT NEDİR (YÖNTEM / YORDAM / FUNCTİON) ? NEDEN KULLANILIR ? -
               Bir iş, operasyon yapan en küçük program parçacıklarıdır.
               Kod tekrarlarının önüne geçer.
               Bir kere yazılan kod her yerden tekrar tekrar çağrılabilir.
                
               Sadce class(sınıf) içerisinde tanımlanır. Metot içinde metot tanımlanmaz.
                
               [erişim blirleyicisi] [geri dönüş değeri] [metot adi]([varsa parametreler])
               {
               }
             Erişim Belirleyicisi = Metotun erişilebilir sınırlarını çizmek için kullanılırız.(Public/private)
             Geri Dönüş Değeri = Metottaki işlemlerin sonucunda ortaya çıkan sonuçtur.

             - METOT TÜRLERİ -
                Yapılacak işlemlere göre 4 farklı şekilde metot tanımlanabilir.
                    * Geriye değer döndürmeyen ve parametre almayan (void)
                    * Geriye değer döndürmeyen ve parametre alan (void)
                    * Geriye değer döndüren ve parametre almayan
                    * Geriye değer döndüren ve parametre alan
        */

            //Metot1();
     

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_BankaUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                  * Kullanıcı adı (string)
                  * şifre  (string)
                  *
                  *Bakiye (int)
                  *
                  * Kullanıcı adı ve şifre doğru girilene kadar değer alınacak
                  * Yapmak istenilen işlem alınacak 
                  * İstenilen işleme göre operasyon yapılır
            */
            string kullaniciAdi = "hasan";
            string sifre = "12345";
            int bakiye = 5000;

            while (true)
            {
                Console.Write("Kullanıcı Adını Giriniz : ");
                string girilenKullaniciAdi = Console.ReadLine();
                Console.Write("Şifrenizi Giriniz : ");
                string girilenSifre = Console.ReadLine();

                if (kullaniciAdi == girilenKullaniciAdi)
                {
                    if (sifre == girilenSifre)
                    {
                        Console.WriteLine("Giriş Başarılı");
                    }
                    else
                    {
                        Console.WriteLine("Şifreniz Yanlış!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Kullanıcı Adınız Yanlış!");
                    continue;
                }

                Console.WriteLine("Para çekmek için 1, para yatırmak 2ye basınız..");

                string islem = Console.ReadLine();
                if (islem == "1")
                {
                    Console.Write("Çekmek istediniğiniz tutarı giriniz");
                    int cekilecekTutar = Convert.ToInt32(Console.ReadLine());
                    bakiye = bakiye - cekilecekTutar;
                    Console.WriteLine("Para Çekme İşlemi Başarılı! Güncel Bakiyeniz : " + bakiye);
                    Console.WriteLine("İyi günler...");
                    break;
                }
                else if (islem == "2")
                {
                    Console.Write("Yatırmak istediniğiniz tutarı giriniz");
                    int yatirilanTutar = Convert.ToInt32(Console.ReadLine());
                    bakiye = bakiye + yatirilanTutar;
                    Console.WriteLine("Yatırma İşlemi Başarılı! Güncel Bakiyeniz : " + bakiye);
                    Console.WriteLine("İyi günler...");
                    break;
                    // para yatırma

                }
                else
                {
                    Console.WriteLine("Geçersiz işlem");
                }
            }



            Console.ReadLine();
        }
    }
}

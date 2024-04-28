namespace _02_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Değişkenler Nedir ?
            /*
             Programlama dillerinde değişkenler, bir değeri saklamak veya temsil etmek için kullanılan adlandırılmış bellek konumlarıdır. Değişkenler, program içinde verilerin depolanması, işlenmesi ve yönetilmesi için temel yapı taşlarıdır.
            */
            #endregion
            #region Değişken Tanımlama
            byte a;
            short b;
            int c;
            long d;
            float f;
            double g;
            decimal h;
            char i;
            string j;
            bool k;

            string kirmiziKalem;

            bool TahtaKalemi;

            int deneme_;

            /*
             - DEĞİŞKEN İSİMLENDİRME TÜRLERİ -
                + Camel Case (denemeDeneme)
                + Pascal Case (DenemeDeneme)
              
             - Değişken İsmi Tanımlama Kuralları -
                + Anlamlı isimlendirmeler yapılmalı
                + Türkçe karakter kullanılmamalı
                + . ? ! gibi özel karakterler içermemeli (_ hariç)
                + Değişken ismi sayı ile başlamamalı.
                + Bir scope içinde aynı isimde sadace ve sadece bir adet değişken bulunmalı
                + Değişken isimleri, tür adları olamaz
             */

            int yas;
            string sehir;
            long _yol_uzunlugu;
            byte ev1;
            //string ev1;
            {
                int x;
            }
            {
                int x;
            }
            // int int;
            // string float;

           

            #endregion
            #region Değişkene Değer Atama
            /*
             Değer atama işlemi = operatörü ile (assign) ile yapılır.
             2 tür değer atama vardır bunlar tanımlama aşamasında ve tanımlandıktan sonradır.
             */
            int q;
            q = 10;
            q = 20;

            int jq = 50;


            int yil = 2024;
            string ad = "hasan";
            char ilkHarf = 'h';
            bool dogrumu = true;
            byte z = 5;
            short y = 6;
            long u = 7;

            float pi1 = 3.14f;
            //float pi1 = 3.14F;
            double pi2 = 3.14d;
            //double pi2 = 3.14D;
            decimal pi3 = 3.14m;
            //decimal pi3 = 3.14M;

            /*
             Tanımlanan değişkenin formatına uygun değerler atanmalıdır.
             */

            //int deneme = "ADF";
            //string harf = 'a';



            /*
             Bir değişkene birden fazla değer atanabilir ve en son değer geçerli olur.
             */
            #endregion
            #region Tanımlanmış Değeri Okuma
            /*
             Bir değeri okuyabilmke için önce bir değişken tanımlanmlaı sonra değer atanmalı ve ardında okunabilir.
             */

            int sayi1 = 25;
            string adim = "hasan";
            Console.WriteLine(adim);
            Console.WriteLine(sayi1);

            int sayi2 = sayi1;




            int a1 = 5;
            int b1 = 25;
            int c1 = b1;
            int d1 = a1;
            b1 = a1;
            c1 = b1;
            Console.WriteLine(c1);

            #endregion
        }
    }
}

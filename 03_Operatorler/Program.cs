namespace _03_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - OPERATOR NEDİR ? -
                 Operatörler, bir veya daha fazla değer arasında belirli bir işlemi gerçekleştiren semboller veya sözcüklerdir. 
                    
                 - ARİTMETİK OPERATÖRLER -
                    + (Toplama)
                    - (Çıkarma)
                    * (Çarpma)
                    / (Bölme)
                    % (Kalan bulma)
                - KARŞILAŞTIRMA OPERATÖRLERİ - (Karşılaştırma operatörleri geriye her daim bool sonuç döner)
                    == (Eşitlik)
                    != (Eşitsizlik)
                    > (Büyüktür)
                    < (Küçüktür)
                    >= (Büyük veya Eşit)
                    <= (Küçük veya Eşit)
                - MANTIKSAL OPERTAÖRLER - (Mantıksal operatörler sadece bool türlerde uygulanır ve geriye her daim bool sonuç döner)
                    && (VE)
                    || (VEYA)
                    ! (DEĞİL)
                - ATAMA OPERATÖRLERİ -
                    += (Toplama ile Atama)
                    -= (Çıkarma ile Atama)
                    *= (Çarpma ile Atama)
                    /= (Bölme ile Atama)
             */
            int a = 10;
            a = a + 1;
            a += 1;

            #region Aritmetik 
            #region Toplama
            int sayi1 = 10;
            int sayi2 = 20;
            int sayi3 = sayi1 + sayi2;
            Console.WriteLine(sayi3);

            string ad = "hasan";
            string soyad = "avcı";
            string adSoyad = ad + soyad;
            Console.WriteLine(adSoyad);
            #endregion

            #region Çıkarma
            int sayi4 = 40;
            int sayi5 = 20;
            int sayi6 = sayi4 - sayi5;
            Console.WriteLine(sayi6);
            #endregion

            #region Kalan Bulma
            int x = 25;
            int y = 6;
            int kalan;
            kalan = x % y;
            Console.WriteLine(kalan);
            #endregion
            #endregion
            #region Karşılaştırma
            int x1 = 20;
            int y1 = 18;
            bool sonuc;

            //sonuc = x1==y1;
            //sonuc = x1 != y1;
            //sonuc = x1 > y1;
            //sonuc = x1 < y1;
            //sonuc = x1 >= y1;
            sonuc = x1 <= y1;

            Console.WriteLine(sonuc);


            #endregion
            #region Mantıksal

            bool bilet = true;
            bool kimlik = false;

            bool sonuc1;

            sonuc1 = bilet && kimlik;
            sonuc1 = bilet || kimlik;
            sonuc1 = !bilet;

            Console.WriteLine(sonuc1);



            #endregion
            #region Atama
            int q1 = 10;

            q1 = q1 + 10;

            q1 += 10;

            q1 -= 10;

            q1 *= 10;

            q1 /= 10;

            #endregion




            #region ++ / -- 

            int t1 = 25;
            int t2 = t1++;
            int t4 = ++t1;
            Console.WriteLine(t1++);
            #endregion
        }
    }
}

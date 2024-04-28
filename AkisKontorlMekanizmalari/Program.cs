namespace _04_AkisKontorlMekanizmalari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                - AKIŞ KONTRÖL MEKANİZMALARI NEDİR ? -
                    Programın belirli koşullara ve durumlara göre nasıl davranacağını kontrol etmek için kullanılan yapısal bileşenlerdir. Akış kontrolü, programın belirli bir yolu izlemesini veya belirli bir kod bloğunu çalıştırmasını sağlar.
                        + if else
                        +switch
                
             */
            /*
                if ve switch birbirinden farklı olsa da aynı işe hizmet ederler
             */


            #region switch case
            // switch casede sadece eşitlik değeri kontrol edilir.
            // Bir sayı küçük mü büyük mü kontrolü yapabilmek için if kullanılmalı. if her türlü kontrolü yaparken swtch sadece eşitlik kontrol eder
            // switch(değer) şitlik durumu sorgulanacak değer 
            // {
            //      case value1:    eşitlik durumları caseler ile kontrol edilir.
            //          break;      işlenen koddan sonra çıkış ypapar . diğer caselere bakmadan çıkar
            //      default:
            //      break;        eşitlik sağlanmazsa default bloğu tetiklenir. zorunlu değildir
            string name = "hasan";
            switch (name)          //kontrol edilen değişken türü ne ise case de yazılan değerler aynı türde olmalı
            {
                case "ahmet": // bunlar değişken olamaz
                    Console.WriteLine("Adı Ahmet");
                    break;
                default:
                    Console.WriteLine("Adı bulunamadı");
                    break;
            }
            // case sıralaması önemli değil


            /*
             Klavyeden girilen sayının (günün) hangi güne ait olduğunu bulan program...
             Klavyeden girilen sayının (ayın) hangi aya ait olduğunu bulan program...
             Kullanıcının girdiği iki sayı ve yapılacak işlem türleri (toplama=1, çıkarma=2, çarpma=3, bölme=4) gösterilen ve  seçilen işlemi yapan C# programını  switch-case ile yazın.
            Klavyeden girilen günün hafta içi veya haftasonu olduğunu bulan C# programını switch-case ile yazın
            Trafik lamba renklerine göre hangi işlemlerin yapılacağını söyleyen C# programını Switch-case ile  yazın. ( Kırmızı : Dur   Sarı : Hazır ol   Yeşil: İlerle)
            Bir kullanıcıdan bir sayı alın ve bu sayının tek mi yoksa çift mi olduğunu kontrol edin.
            Kullanıcıdan bir hafta günü adı alın ve bu günün iş günü mü yoksa hafta sonu mu olduğunu belirtin.
             */
            #endregion


            #region if else
            /*
                switch casede sadece eşitlik durumu kontrol edilirken if elsede küçüktür büyüktür her türlü kontrol sağlanabilir. else kullanmak zorunlu değil
                
                if (şart)  şart doğru ise yazılım scope içine girer false ise girmez (şart bool olmalılıdr) karşılaştırma ve mantıksal oprt. kullanılabilir.
                {
                }

            

             */
            bool medeniHal = true;
            if (medeniHal == true)
            {
                Console.WriteLine("Evli");
            }
            int i = 10;
            if (i > 5)
            {
                Console.WriteLine("i büyüktür 5");

            }
            // else ifin doğru olmadığı duumda tetiklenir(kesinlikle)
            if (i > 5)
            {
                Console.WriteLine("i büyüktür 5ten");
            }
            else
            {
                Console.WriteLine("i küçüktür 5ten");

            }


            // if else if ile birden fazla şartı kontrol edebilirz. istenilen kadar else if yazılabilir.
            // Doğru olan ilk şart bloğuna girer ve diğerlerine girmez

            if (i < 5)
            {
                Console.WriteLine("i 5ten küçük");
            }
            else if (i < 10) 
            {
                Console.WriteLine("i 10ten küçük");

            }
            else if (i < 20)
            {
                Console.WriteLine("i 20ten küçük");

            }

            /*
             
             + Klavyeden girilen sayının tek mi, çift mi olduğunu gösteren C# programını yazalım.
            
             + Kullanıcıdan girdiği iki sayı ve yapılacak işlem türü (toplama, çıkarma, çarpma, bölme) seçildiğinde, 
                sonucu hesaplayarak ekranda gösteren programı yazalım.
             
             +Belirlenen kullanıcı adı ve şifre doğru girildiğinde “Giriş Başarılı”,
                 yanlış girildiğinde “Girdiğiniz kullanıcı adı veya şifre hatalı” mesajı veren Console uygulamasını yapalım
             +Bir mağazada alınan ürünün fiyatı 100 Tl ve üzerinde ise 5 Tl olan kargo ücreti alınmamaktadır. Ürünün fiyatı girildiğinde
                  toplam ödenmesi gereken tutarı gösteren programı yazalım.
             */
            #endregion


            bool durum = false;

            if (10 > 11 && 9 == 9 && durum == true && "q" == "Q" || 1 != 2) // true - false -- false ve true ve false ve false veya true
            {
                Console.WriteLine("if durumu doğru");
            }
            else
            {
                Console.WriteLine("if durumu yanlış");
            }

            int a = 0;
            switch (a)
            {
                case 1:
                    Console.WriteLine("h");
                    break;
                case 2:
                    Console.WriteLine("h");
                    break;
                default:
                    break;
            }


        }
    }
}

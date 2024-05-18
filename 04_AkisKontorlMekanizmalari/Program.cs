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
            // switch(değer) eşitlik durumu sorgulanacak değer 
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
                case "Hasan":
                    Console.WriteLine("hasan");
                    break;
                
            }
            // case sıralaması önemli değil


         
            #endregion


            #region if else
            /*
                switch casede sadece eşitlik durumu kontrol edilirken if elsede küçüktür büyüktür dahil her türlü kontrol sağlanabilir. else kullanmak zorunlu değil
                
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
            // else ifin sağlanmadığı  durumda tetiklenir(kesinlikle)
            if (i > 5)
            {
                Console.WriteLine("i büyüktür 5ten");
            }
            else
            {
                Console.WriteLine("i küçüktür 5ten");

            }


            // if else if ile birden fazla şartı kontrol edebilirz. İstenildiği kadar else if yazılabilir.
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
                    Console.WriteLine("test1");
                    break;
                case 2:
                    Console.WriteLine("test2");
                    break;
                default:
                    break;
            }


        }
    }
}

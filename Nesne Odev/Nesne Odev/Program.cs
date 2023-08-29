/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ                                    *
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                   *
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                          *
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ                         *
**					2020-2021 BAHAR DÖNEMİ                                  *
**	                                                                        *
**				ÖDEV NUMARASI:1                                             *
**				ÖĞRENCİ ADI: Yavuz ARSLAN                                   *
**				ÖĞRENCİ NUMARASI: G201210087                                *
**              DERSİN ALINDIĞI GRUP: 2-C                                   *
****************************************************************************/



using System;
using System.Threading;

namespace Nesne_Odev
{
    class Program
    {
        // Rastgele sayıları üretebilmek için kendi üretecimi tanıtıyorum.
        static Random random = new Random();

        static void Main()
        {

            Console.WriteLine("--------------------Menü--------------------");
            Console.WriteLine("a-Kale odevi icin tiklayiniz.");
            Console.WriteLine("b-String odevi icin tiklayiniz.");
            Console.WriteLine("c-Cikis yapmak icin tiklayiniz.");
            //ana menu için tuşlama yapılabilmesi için bir tane int tanımlayıp chara çevirdim.
            int anamenu;

            anamenu = char.Parse(Console.ReadLine());
            // kullanıcı a' ya basarsa geleceği koşul.
            if (anamenu == 'a' || anamenu == 'A')
            {

                //8x8lik bir dizi oluşturacağımı belirtiyorum.

                bool[,] rook = new bool[8, 8];

                // gerekli olan değişkenleri tanımlıyorum

                int number1, number2;
                int RookCounter = 0;


                // her şeyin olacağını sonsuz while döngüsüne alıyorum.
                while (true)

                {
                    //biri satır biri sütun olmak üzere iki tane random sayı üretiyorum.

                    number1 = random.Next(0, 8);
                    number2 = random.Next(0, 8);

                    //bazı işlemleri doğruysa böyle yanlışsa böyle yapması için bir tane testbool u tanımlıyorum ve false veriyorum.
                    bool testbool = false;


                    // burada sekiz tane 2li sayı seçmesi için bir for döngüsü yazıyorum.


                    for (int i = 0; i < 8; i++)
                    {
                        /*burada döngüde seçeceği sayıları öyle bir seçsin ki seçtiği sayılar önceden seçtiği sayılarla
                        aynı dikeyde veya yatayda olmasın diye kontrol ettiriyorum eğer öyle değillerse kabul ediyorum
                        değillerse tekrardan ikili ürettiriyorum*/

                        if (rook[number1, i] == true)
                        {
                            testbool = true;
                            break;
                        }

                        else if (rook[i, number2] == true)
                        {
                            testbool = true;
                            break;

                        }
                    }

                    // her uygun ikili seçtiğinde kale sayacını bir arttırıyorum.

                    if (testbool == false)
                    {
                        rook[number1, number2] = true;
                        RookCounter++;

                    }

                    //İnsan gözü rahatça aradığını anlayabilsin diye kullandım.
                    Thread.Sleep(150);

                    //Her tahtayı koyduktan sonra öncekini silsin diye kullandığım fonksiyon.
                    Console.Clear();

                    //Burada 8x8lik tahtamı çizdiriyorum.iki boyutlu olduğu için iç içe iki döngü kullanıyorum.

                    for (int i = 0; i < 8; i++)

                    {

                        for (int j = 0; j < 8; j++)

                        {

                            Console.Write("{");
                            if (rook[i, j] == true)
                            {
                                Console.Write("R");
                            }

                            else
                            {
                                Console.Write(" ");
                            }

                            Console.Write("}");



                        }

                        Console.WriteLine();



                    }

                    //Kale sayacı 8 olduğu zaman sonsuz while döngüsünden çıkması için break kullanıyorum.
                    if (RookCounter == 8)
                    {
                        break;
                    }

                }

                Main();
            }

            // Kullanıcı b seçeneğini seçerse geleceği koşul.

            if (anamenu == 'b' || anamenu == 'B')
            {
                Console.Clear();

                Console.WriteLine("--------------------Menü--------------------");
                Console.WriteLine("a-String bir değişkende, string değeri substing kullanmadan ara.");
                Console.WriteLine("b-String bir değişkende, string değeri substing kullanarak ara.");
                Console.WriteLine("c-Alfabenin karakterlerini bir string içerisinde ara.");
                Console.WriteLine("d-Ana menuye donmek icin tıklayiniz.");

                //Gerekli değişkenleri tanımladım ve bazılarını dönüştürdüm.

                int secim;
                secim = char.Parse(Console.ReadLine());
                int devam;
                int harfSayisi = 0;
                string metin;
                string aranacakMetin;

                // bütün harfleri,sayıları ve noktalama işareletlerini tek bir stringte topladım.

                String karakterler = "0123456789abcçdefgğhıijklmnoöpqrsştuüvwxyz.?,; ";

                //kullanıcı çıkmak isteyene kadar kalsın diye sonsuz bir döngü oluşturdum.

                while (true)
                {
                    // bu menüde a ya tıklarsa geleceği koşul.
                    if (secim == 'a')
                    {
                        
                        Console.WriteLine("Secimiz 1.seçenek.");
                        Console.WriteLine("Lütfen metninizi giriniz.");

                        //Büyük küçük harflere duyarlı olmasın diye hepsini küçük aldım.

                        metin = Console.ReadLine().ToLower();

                        Console.WriteLine("Lütfen metinde aramak istediğiniz metini giriniz.");

                        //Büyük küçük harflere duyarlı olmasın diye hepsini küçük aldım.

                        aranacakMetin = Console.ReadLine().ToLower();

                        metin = metin.ToLower();

                        int indis = 0;

                        //Girilen metnin kaç karakter içerdiğini gösterir.

                        Console.WriteLine("Yukarıdaki ifade toplam {0} karakter içerir.", metin.Length);

                        // eğer aranan metinde içeriyorsa buraya geliyor.

                        if (metin.Contains(aranacakMetin))
                        {
                                //burada metin sonuna kadar giden bir döngü yazdım.

                                for (int i = 0; i < metin.Length; i++)
                                {   

                                    // eğer metin sonuna kadar bir yerde rastladıysa bunun i sayısını indise geçiriyorum.

                                    indis = metin.IndexOf(aranacakMetin, i);

                                    // sonrasında i yi kendim arttırıyorum ki aynı indisleri tekrar etmesin.

                                    i = indis + aranacakMetin.Length;

                                    // sonuncusunu bulduktan sonra bulamayacağı için -1 olacak o yüzden -1de döngüyü kırıyorum.
                                   
                                    if (indis == -1)
                                    {
                                        break;
                                    }

                                    // ve indisleri yazdırıyorum.

                                    Console.WriteLine(indis);
                                }
                            
                        }
                        // içermiyorsa kullanıcıya gereken dönütü veriyor.
                        else
                            Console.WriteLine("Aradiginiz metin bulunamamaktadir.");

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Devam etmek istiyor musunuz?e/h");
                        Console.WriteLine();
                        Console.WriteLine();

                        devam = char.Parse(Console.ReadLine());

                        //Kullanıcı devam etmek istiyorsa.

                        if (devam == 'e' || devam == 'E')
                        {
                            Console.Clear();
                            continue;
                        }

                        //etmek istemiyorsa.

                        else if (devam == 'h' || devam == 'H')
                        {
                            Console.WriteLine("Ana Menuye yonlendiriliyorsunuz.");
                            Console.Clear();
                            Main();

                        }

                        // kullanıcı girebileceği tuşlar haricinde tuşlara bastıysa ana menüye at.

                        else if (devam != 'e' || devam != 'E' || devam != 'h' || devam != 'H')

                        {
                            Console.Clear();
                            Console.WriteLine("Yanlis tuslama yapildi.Ana menuye yonlendiriliyorsunuz.");

                            Main();
                        }

                    }

                    //Substring kullanarak yapma.

                    if (secim == 'b')
                    {
                        Console.WriteLine("Secimiz 2.seçenek.");
                        Console.WriteLine("Lütfen metninizi giriniz.");

                        //Büyük küçük harf duyarlılığı olmasın diye.

                        metin = Console.ReadLine().ToLower();

                        Console.WriteLine("Lütfen metinde aramak istediğiniz metini giriniz.");

                        //Büyük küçük harf duyarlılığı olmasın diye.

                        aranacakMetin = Console.ReadLine().ToLower();

                        //Büyük küçük harf duyarlılığı olmasın diye.

                        metin = metin.ToLower();

                        //Girilen metnin kaç karakter içerdiğini gösterir.

                        Console.WriteLine("Yukarıdaki ifade toplam {0} karakter içerir.", metin.Length);

                        int indis = 0;

                        // eğer aranan metin girilen metin içinde yer alıyorsa.

                        if (metin.Contains(aranacakMetin))

                        {

                            //metnin sonua kadar döngüyle gidiyorum.

                            for (int i=0; i<=metin.Length;i++)
                            {
                                //eğer aranacak metin metnin başında yer alıyorsa.

                                if (metin.StartsWith(aranacakMetin))
                                {

                                    indis = metin.IndexOf(aranacakMetin, i);
                                    i = indis + aranacakMetin.Length;
                                    if (indis == -1)

                                    {

                                        break;

                                    }

                                    Console.WriteLine(indis);



                                    

                                }

                                //eğer aranacak metin metnin başında değilse.

                                if (aranacakMetin==metin.Substring(i));
                                {

                                    indis = metin.IndexOf(aranacakMetin, i);
                                    i = indis + aranacakMetin.Length;

                                }

                                //bulamayınca döngüden çık.

                                if(indis==-1)

                                {

                                    break;

                                }

                                Console.WriteLine(indis);

                            }

                        }

                        // eğer aranan metni girilen metinde bulamazsa.

                        else
                            Console.WriteLine("Aradiginiz metin bulunamamaktadir.");


                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Devam etmek istiyor musunuz?e/h");
                        Console.WriteLine();
                        Console.WriteLine();

                        devam = char.Parse(Console.ReadLine());
                        
                        // eğer devam edilmek isteniyorsa.

                        if (devam == 'e' || devam == 'E')
                        {
                            Console.Clear();
                            continue;
                        }

                        // eğer devam edilmek istenmiyorsa.

                        else if (devam == 'h' || devam == 'H')
                        {
                            Console.WriteLine("Ana Menuye yonlendiriliyorsunuz.");
                            Console.Clear();
                            Main();

                        }

                        //eğer kullanıcı girebileceği dışında tuşlara bastıysa.

                        else if (devam != 'e' || devam != 'E' || devam != 'h' || devam != 'H')

                        {
                            Console.Clear();
                            Console.WriteLine("Yanlis tuslama yapildi.Ana menuye yonlendiriliyorsunuz.");
                            Main();
                        }

                    }

                    // c koşulunu seçen kullanıcının geleceği yer.

                    if (secim == 'c')



                    {

                        
                        Console.WriteLine("Secimiz 3.seçenek.");
                        Console.WriteLine("Lütfen metninizi giriniz.");

                        metin = Console.ReadLine();

                        // stringleri cümle cümle alıp kaydeder taki boş string girilene kadar.

                        do
                        {
                            string metin1 = Console.ReadLine();
                            metin = metin + metin1;
                        } while (Console.ReadKey (true).Key != ConsoleKey.Enter);
                        

                        // girilen metnin kaç karakter olduğunu gösterir.

                        Console.WriteLine("Yukarıdaki ifade toplam {0} karakter içerir.", metin.Length);

                        // karakterler adında bir dizi oluşturuyorum.

                        int[] count = new int[karakterler.Length];

                        // harfleri küçük büyük ayırmasın diye hepsini küçüğe döndürüyorum.

                        metin = metin.ToLower();

                        //metnin sonuna kadar okutuyorum.

                        for (int i = 0; i < metin.Length; i++)
                        {
                            // index diye bir değişken oluşturuyorum ve metnin içinde i'yle beraber ilerletiyorum.


                            int index = karakterler.IndexOf(metin[i]);

                            // eğer küçükse sıfırdan devam ediyor.

                            if (index < 0)
                                continue;

                            // değilse index sayacını arttırıyorum.

                            else
                            {
                                count[index]++;
                            }
                        }

                        // sayacın en büyüğüne kadar okutuyorum.

                        for (int i = 0; i < count.Length; i++)


                        {
                            // eğer sayac 0 ise ekrana istenilen basılıyor.

                            if (count[i] < 1)

                                Console.WriteLine(karakterler[i] + " karakterinin sayisi: ");

                            // eğer sayac 0'dan büyük ise ekrana sayısı ve sayısı kadar yıldız bastıran döngüyü yazıyorum.

                            else
                            {

                                Console.Write(karakterler[i] + " karakterinin sayisi: " + count[i]);
                                for (int j = 0; j < count[i]; j++)
                                {
                                    Console.Write(" * ");
                                }

                                Console.WriteLine();
                            }

                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Devam etmek istiyor musunuz?e/h");
                        Console.WriteLine();
                        Console.WriteLine();

                        devam = char.Parse(Console.ReadLine());

                        //kullanıcı devam etmek istiyorsa.

                        if (devam == 'e' || devam == 'E')
                        {
                            Console.Clear();
                            continue;
                        }

                        //kullanıcı devam etmek istemiyorsa.

                        else if (devam == 'h' || devam == 'H')
                        {
                            Console.WriteLine("Ana Menuye yonlendiriliyorsunuz.");
                            Console.Clear();
                            Main();

                        }

                        // kullanıcı hatalı tuşlama yaptıysa.

                        else if (devam != 'e' || devam != 'E' || devam != 'h' || devam != 'H')

                        {
                            Console.Clear();
                            Console.WriteLine("Yanlis tuslama yapildi.Ana menuye yonlendiriliyorsunuz.");
                            Main();
                        }

                    }

                    // eğer kullanıcı ana menüye dönmek istiyorsa.

                    if (secim == 'd')
                    {
                        Console.Clear();
                        Thread.Sleep(150);
                        Console.WriteLine("Ana Menuye donmek icin tiklayiniz.");
                        Main();
                    }

                    //eğer kullanıcı başka bir şey girdiyse

                    if (secim != 'a' || secim!='A'|| secim != 'b'|| secim!='B'|| secim != 'c' || secim != 'C' || secim != 'd' || secim != 'D' )
                    {
                        Console.Clear();
                        Console.WriteLine("Yanlis tuslama yapildi.Lutfen  a,b,c veya d tuslarindan birine tiklayiniz");
                        Main();
                    }

                }
            }

            // eğer kullanıcı çıkış yapmak istiyorsa.

            if (anamenu == 'c')
            {
                Thread.Sleep(150);
                Console.WriteLine("Cikis yapiyorsunuz,Selametle.");
                Environment.Exit(150);

            }

            // eğer kullanıcı yanlış bir şey tıkladıysa.

            if (anamenu != 'a' || anamenu != 'A' || anamenu != 'b' || anamenu != 'B')
            {
                Console.WriteLine("Yanlis tuslama yapildi.Ana menuye yonlendiriliyorsunuz.");
                Main();
            }
        }

    }
}

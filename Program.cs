using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notdagilimi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Not Dağılımı Grafiksel Gösterim Yazılımı");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1-Sıralı Not Girişi");
            Console.WriteLine("2-Dağınık Not Girişi");
            string cevap = "";
            int sayi = 0;

            int notCesidi = 0;
            bool secim;
            do
            {
                do
                {
                    Console.Write("Lütfen bir seçim yapınız:");
                    secim = int.TryParse(Console.ReadLine(), out sayi);
                    switch (sayi)
                    {
                        case 1:
                            string[] harfNotlari = { "AA", "BA", "BB", "CB", "CC", "DC", "DD", "FF" };
                            int[] notSayisi = new int[harfNotlari.Length];
                            for (int i = 0; i < harfNotlari.Length; i++)
                            {
                                do
                                {
                                    if (!secim)
                                    {
                                        Console.WriteLine("Lütfen sayısal bir değer giriniz.");
                                    }
                                    Console.Write($"Kaç tane {harfNotlari[i]} olduğunu giriniz:");
                                    secim = int.TryParse(Console.ReadLine(), out notSayisi[i]);
                                }
                                while (!secim);
                            }
                            Grafik(harfNotlari, notSayisi);
                            break;
                        case 2:
                            do
                            {
                                Console.Write("Grafikte kaç çeşit harf notu olacağını giriniz:");
                                secim = int.TryParse(Console.ReadLine(), out notCesidi);
                                if (!secim)
                                {
                                    Console.WriteLine("Lütfen sayısal bir değer giriniz.");
                                }
                            }
                            while (!secim);
                            string[] harfnotuCesitleri = new string[notCesidi];
                            int[] notSayisi2 = new int[notCesidi];
                            for (int i = 0; i < notCesidi; i++)
                            {
                                Console.Write("Harf notu ifadesini giriniz:");
                                string harfNotu = Console.ReadLine();
                                while (harfNotu.Length != 2)
                                {
                                    Console.WriteLine("Harf notu 2 karakter olmalıdır:");
                                    Console.Write("Harf notu ifadesini giriniz:");
                                    harfNotu = Console.ReadLine();
                                }
                                harfnotuCesitleri[i] = harfNotu;
                                do
                                {
                                    if (!secim)
                                    {
                                        Console.WriteLine("Lütfen sayısal bir değer giriniz.");
                                    }
                                    Console.Write($"Kaç tane {harfnotuCesitleri[i]} oldugunu giriniz:");
                                    secim = int.TryParse(Console.ReadLine(), out notSayisi2[i]);
                                }
                                while (!secim);
                            }
                            Grafik(harfnotuCesitleri, notSayisi2);
                            break;
                        default:
                            if (sayi > 2)
                            {
                                Console.WriteLine("lütfen geçerli seçim yapınız");
                                secim = false;
                            }
                            else
                                Console.WriteLine("Lütfen sayısal bir değer giriniz!!!!!");
                            break;
                    }
                }
                while (!secim);
                Console.WriteLine("Yeni bir grafik oluşturmak için E harfine basın");
                cevap = Console.ReadLine();
            }
            while (cevap == "E");
            if(cevap!="E")
            {
                Console.WriteLine("Çıkmak için bir tuşa basınız");
            }
            Console.ReadKey();
        }
        static void Grafik(string[] harfNotlari, int[] notSayisi)
        {
            Console.WriteLine(" ADET");
            Console.WriteLine(" ^");
            int maxElement = notSayisi.Max() + 1;
            for (int i = 0; i < maxElement; i++)
            {
                Console.Write(" | ");
                for (int j = 0; j < notSayisi.Length; j++)
                {
                    if ((maxElement - i) <= notSayisi[j])
                        Console.Write(" * ");
                    else
                        Console.Write("   ");
                }
                Console.WriteLine();
            }
            Console.Write("    ");
            for (int i = 0; i < harfNotlari.Length; i++)
            {
                Console.Write("---");
            }
            Console.WriteLine(" >NOTLAR");           
            Console.Write("    ");
            for (int i = 0; i < harfNotlari.Length; i++)
            {
                Console.Write(harfNotlari[i]+" ");
            }
            Console.WriteLine();
        }
    }
}

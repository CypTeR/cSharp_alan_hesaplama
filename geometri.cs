using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class Alan
    {
        static void Main(string[] args)
        {/* BU KODLAR Mikail AKSU'ya aittir!*/
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------ALAN HESAPLAMA V1------\n");
            Console.WriteLine("Dijayner: Mikail AKSU 461 10/A \nEnes Köksal KILIÇ 444 10/A\n");
            Console.WriteLine("Üçgenin alanı için 1'e \nKarenin alanı için 2'ye \nDikdörtgenin alanı için 3'e\nDairenin alanı için 4'e\nYamuğun alanı için 5'e \nBeşgenin alanı için 6'ya \nSilindirin alanı için 7'ye \nPiramitin alanı için 8'e \nParalel kenarın alanı için 9'a \nEşkenar Altigenin Alanı için 10'a Basınız...\n");
            Console.Write("Yapmak istediğiniz işlemi girin:");
            double secim = Convert.ToDouble(Console.ReadLine());
            if (secim == 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------ÜÇGEN ALAN HESAPLAMA------");
                Console.Write("Yüksekliği giriniz:");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Yüksekliğe ait kenar: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                double sonuc = ucgen(sayi1, sayi2);
                Console.WriteLine(sonuc);
            }
            else if (secim == 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------KARE ALAN HESAPLAMA------");
                Console.Write("1. kenarı giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("2. kenarı giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                double sonuc = kare(sayi1, sayi2);
                Console.WriteLine(sonuc);
            }
            else if (secim == 3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------DİKDÖRTGEN ALAN HESAPLAMA------");
                Console.Write("uzun kenarı giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("kısa kenarı giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                double sonuc = dikdortgen(sayi1, sayi2);
                Console.WriteLine(sonuc);
            }
            else if (secim == 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------DAİRE ALAN HESAPLAMA------");
                Console.Write("yarı çapı giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                double pi = 3.1415;
                double sonuc = daire(sayi1, pi);
                Console.WriteLine(sonuc);
            }
            else if (secim == 5)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("------YAMUK ALAN HESAPLAMA------");
                Console.Write("alt kenarı giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("üst kenarı giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("yüksekliği giriniz: ");
                double sayi3 = Convert.ToDouble(Console.ReadLine());
                double sonuc = yamuk(sayi1, sayi2, sayi3);
                Console.WriteLine(sonuc);
            }
            else if (secim == 6)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("------BEŞGEN ALAN HESAPLAMA------");
                Console.Write("Kenar uzunluğunu girin:");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Yarıçap uzunluğunu girin: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                double sonuc = besgen(sayi1, sayi2);
                Console.WriteLine(sonuc);
            }
            else if (secim == 7)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("------SİLİNDİR ALAN HESAPLAMA------");
                Console.Write("yüksekliği girin:");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Yarıçap uzunluğunu girin: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                double sonuc = silindir(sayi1, sayi2);
                Console.WriteLine(sonuc);
            }
            else if (secim == 8)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("------PİRAMİT ALAN HESAPLAMA------");
                Console.Write("alt kenarı giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("yüksekliği giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                double sonuc = piramit(sayi1, sayi2);
                Console.WriteLine(sonuc);
            }
            else if (secim == 9)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("------PARALEL KENAR ALAN HESAPLAMA------");
                Console.Write("taban kenarı giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("yüksekliği giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                double sonuc = paralelkenar(sayi1, sayi2);
                Console.WriteLine(sonuc);
            }
            else if (secim == 10)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------ALTIGEN ALAN HESAPLAMA------");
                Console.Write("Kernarı giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                double sonuc = altigen(sayi1);
                Console.WriteLine(sonuc);
            }
            else
                Console.WriteLine("YANLIŞ SEÇİM!!!");
            Console.ReadLine();
        }
        public static double ucgen(double say1, double say2)
        {
            double sonuc = (say1 * say2)/2;
            return sonuc;
        }
        public static double kare(double say1, double say2)
        {
            double sonuc = say1 * say2;
            return sonuc;
        }
        public static double dikdortgen(double say1, double say2)
        {
            double sonuc = say1 * say2;
            return sonuc;
        }
        public static double daire(double say1, double say2)
        {
            double sonuc = say1 * say2;
            return sonuc;
        }
        public static double yamuk(double a, double b, double h)
        {
            double sonuc = ((a + b) / 2) * h;
            return sonuc;
        }
        public static double besgen(double a, double r)
        {
            double sonuc = 5 * ((a * r) / 2);
            return sonuc;
        }
        public static double silindir(double h, double r)
        {
            double sonuc = h * r;
            return sonuc;
        }
        public static double piramit(double a, double h)
        {
            double sonuc = a * (a + Math.Sqrt((a * a) + (4 * h * h)));
            return sonuc;
        }
        public static double paralelkenar(double say1, double say2)
        {
            double sonuc = say1 * say2;
            return sonuc;
        }
        public static double altigen(double a)
        {
            double sonuc = 3 * (Math.Sqrt(3) / 2) * (a * a);
            return sonuc;
        }
    }
}

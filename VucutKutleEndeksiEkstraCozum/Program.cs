using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VucutKutleEndeksiEkstraCozum
{
    class Program
    {
        static void Main(string[] args)
        {
            BaslikYaz();
            double boy = Giris("Boy giriniz:");
            double kilo = Giris("Kilo giriniz: ");
            double endeks = EndeksHesapla(boy, kilo);
            Console.WriteLine($"Endeks: {endeks}");
            HesapSonucunuYazdır(endeks);
            Console.ReadLine();
        }

        private static void HesapSonucunuYazdır(double endeks)
        {
            Console.Write("BMI: ");
            if ( endeks < 18)
                Console.WriteLine("Zayıf");
            else if ( endeks >= 18 && endeks <25)
                Console.WriteLine("Normal");
            else if (endeks >= 25 && endeks <30)
                Console.WriteLine("Kilolu");
            else if (endeks >=30 && endeks <35)
                Console.WriteLine("Obez");
            else
                Console.WriteLine("Ultra Obez");
        }

        /// <summary>
        /// Gönderilen boy ve kiloya göre endeks hesaplar.
        /// </summary>
        /// <param name="boy"></param>
        /// <param name="kilo"></param>
        /// <returns></returns>
        static double EndeksHesapla(double boy, double kilo)
        {
            double endeks = kilo / (boy * boy);
            return endeks;

        }

        static void BaslikYaz()
        {
            Console.WriteLine("*** BMI HESAPLAMA ***");
        }

        static double Giris(string mesaj)
        {
            double giris;
            Console.Write(mesaj);
            giris = Convert.ToDouble(Console.ReadLine());
            return giris;
        }
    }
}

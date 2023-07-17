using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Ekrandan girilen sayıya kadar tek sayıları ekrana yazdır");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=sayi; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();*/


            
            int tektoplam = 0;
            int cifttoplam = 0;
            Console.WriteLine("1 ile 1000 arasındaki tek ve çift sayıların toplamlarını ekrana göster");
            for (int i = 1; i <=1000; i++)
            {
                if (i%2==0)
                {
                    cifttoplam += i;
                }
                else if (i%2==1)
                {
                    tektoplam += i;
                }
            }
            Console.WriteLine("Tek sayıların toplamı: "+tektoplam);
            Console.WriteLine("Çift sayıların toplamı: "+cifttoplam);
            Console.ReadLine();
        }
    }
}

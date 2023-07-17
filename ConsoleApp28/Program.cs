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
            Console.WriteLine("ATM");
            Console.WriteLine("Lütfen bir seçenek seçiniz: ");
            Console.WriteLine("1 para çekme");
            Console.WriteLine("2 para yatırma");
            Console.WriteLine("3 Bakiye sorgulama");
            Console.WriteLine("4 Çıkış yap");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine("Para çekebilirsiniz");
                    break;
                case 2: Console.WriteLine("Para yatırabilirsiniz");
                    break;
                case 3: Console.WriteLine("Bakiyenizi görebilirsiniz");
                    break;
                case 4: Console.WriteLine("Çıkış yaptınız");
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir seçeneği tuşlayınız");
                    break;
            }
            Console.ReadLine();
        }
    }
}

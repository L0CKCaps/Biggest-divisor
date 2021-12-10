using System;

namespace enbb
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("x sayısı girin");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y sayısı girin");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y)    //x 30 y 20 
            {
                int a = y;
                y = x;              //x 20 y 30
                x = a;
            }

            int ebob = 0;
            for (int i = 1; i <=x; i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    ebob = i;
                }
            }
            Console.WriteLine(ebob);












            //bir sayının bölenleri
            /*
              int sayi;
            Console.WriteLine("SAYI GİRİN: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */
        }
    }
}

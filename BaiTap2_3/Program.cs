using System;
namespace Bai2_3
{
    class BaiTapVeNha
    {
        static void Main(string[] args)
        {
            int x=100,tong=100,tram,chuc,donvi;
            for (int i = 100; i < 999; i++)
            {
                x++;
                tram = x / 100;
                donvi = x % 10;
                chuc = (x - (tram * 100) - donvi)/10;
                tong = tram + chuc + donvi;
                //Console.WriteLine("So hang tram, chuc, don vi : {0} {1} {2}", tram, chuc, donvi);
                if (tong % 2 == 0)
                {
                    Console.WriteLine("Tong 3 so cua so {0} la mot so chan !", x);
                    Console.WriteLine("So tong la : {0} ", tong);
                }
                
            }
        }

    }
}
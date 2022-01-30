using System;

namespace DizilerProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String türünde dizi tanımlama
            string[] isimler = { "Ahmet", "Mehmet", "Ali", "Veli" };
            Console.WriteLine(isimler[0]);

            //İnteger türünce dizi tanımlama
            int[] sayilar = new int[5];
            sayilar[0] = 1200;
            sayilar[1] = 1201;
            sayilar[2] = 1202;
            sayilar[3] = 1203;
            sayilar[4] = 1204;
           
            Console.WriteLine(sayilar[4]);


            //İnteger türünce dizi tanımlama ve for ile yazdırma

            int[] number = new int[6];
            number[0] = 10;
            number[1] = 100;
            number[2] = 1000;
            number[3] = 10000;
            number[4] = 100000;
            number[5] = 1000000;

            for (int i = 0; i <number.Length; i++)
            {
                Console.WriteLine(number[i]);
                
            }
            Console.ReadLine();

        }
    }
}

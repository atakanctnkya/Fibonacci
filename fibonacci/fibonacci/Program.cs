using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int kacaKadar, bir=0, iki=1, uc;

            Console.Write("Serinin kaçıncı elemana kadar devam etmesini istiyorsunuz = ");

            
            while (true)
            {
                kacaKadar = int.Parse(Console.ReadLine());

                if (kacaKadar > 0)
                {
                    Console.WriteLine("\nFİBONACCİ SERİSİ {0}. ELEMANA KADAR YAZDIRILIYOR",kacaKadar);
                    if (kacaKadar == 1)
                    {
                        Console.WriteLine(bir);

                    }
                    else
                    {
                        Console.WriteLine(bir + "\n" + iki);
                        for (int i = 0; i < kacaKadar - 2; i++)
                        {
                            uc = bir + iki;
                            bir = iki;
                            iki = uc;
                            Console.WriteLine(uc);

                        }
                        bir = 0;
                        iki = 1;

                    }
                    Console.Write("FİBONACCİ SERİSİ TAMAMLANDI.");

                    Console.ReadLine();
                    break;
                    

                }
                else
                {
                    Console.WriteLine("Lütfen 0 dan büyük bir değer giriniz.");
                }


            }

           

        }
    }
}

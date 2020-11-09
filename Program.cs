using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace NotHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
             
             
            double  toplamsonuc, herbirsorukacpuan1 , net,bolunum ,sorusayisi1,bos, dogru1, yanlis1, kacyanlisbir1 = 0;
            
            
              
          
        

            Console.WriteLine("PUAN HESAPLAMA PROGRAMINA HOŞGELDİNİZ");
            Console.WriteLine("SORU SAYISINI GİRiNİZ");
            sorusayisi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("HER BİR SORU KAÇ PUAN");
            herbirsorukacpuan1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("KAÇ YANLIŞ BİR DOĞRUYU GÖTÜRÜYOR");
            kacyanlisbir1 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("DOĞRU SAYISINI GİRİNİZ");
            dogru1 = Convert.ToInt32(Console.ReadLine());

            if ( sorusayisi1  < dogru1 )
            {
                Console.WriteLine("DOĞRU , SORU SAYISINDAN FAZLA OLAMAZ");
                return;
            }


            Console.WriteLine("YANLIŞ SAYISINI GİRİNİZ");
            yanlis1 = Convert.ToInt32(Console.ReadLine());

         

            if (sorusayisi1 < yanlis1)
            {
                Console.WriteLine("YANLIŞ , SORU SAYISINDAN FAZLA OLAMAZ ");
                return;
            }

            bolunum = yanlis1 / kacyanlisbir1; 
            net = dogru1 - bolunum;

            bos = sorusayisi1 - net;

            toplamsonuc = net * herbirsorukacpuan1;

            Console.WriteLine($"SINAV NOTUNUZ  :{toplamsonuc}" );
            Console.WriteLine($"TOPLAM NETİNİZ : {net}");
            Console.WriteLine($"DOĞRU SAYINIZ  : {dogru1}");
            Console.WriteLine($"YANLIŞ SAYINIZ : {bolunum}");
            Console.WriteLine($"BOŞ SAYINIZ : {bos}"); 
            Console.ReadKey();

        }
    }
}

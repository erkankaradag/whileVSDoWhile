
  
 // While döngüsünde sayacımız 0'dır. Koşulumuz girilen limitin sayaçtan büyük olması gerektiğini ifade etmektedir. Bu sebeple 0'ın altında sayı girilmesi durumunda koşul çalışmayacaktır. 0'ın üstünde herhangi bir sayı girilmesi durumunda da sıfırda dahil olmak üzere ekrana o kadar çıktı verecektir.
using System;
namespace WhileVSDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.WriteLine("Lütfen bir limit girin: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            while (sayac <= limit)
            { 
                Console.WriteLine("Ben bir Patika'lıyım"); 
                sayac++;
            }

        }
    }
}

// Do While döngüsünde sayacımız 0'dır. Koşulumuz girilen limitin sayaçtan büyük olması gerektiğini ifade etmektedir. Bu sebeple 0'ın altında sayı girilmesi durumunda koşul yalnızca bir kez çalışacak ve koşul sağlanmadığı için sonlanacaktır. 0'ın üstünde herhangi bir sayı girilmesi durumunda da sıfırda dahil olmak üzere girilen limit kadar ekrana çıktı verecektir.
/*
using System;

namespace pratiK2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.WriteLine("Lütfen bir limit girin: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Ben bir Patiika'lıyım!");
                sayac++;
            }
            while (sayac <= limit);

        }
    }
}
*/
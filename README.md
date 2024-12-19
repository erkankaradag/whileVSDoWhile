# While ve Do While Döngüleri

Bu projede `while` ve `do while` döngülerinin temel farklarını anlamak için iki ayrı örnek kod bulunmaktadır. Aşağıda her iki örnek kod ve farkları açıklanmıştır.

---

## While Döngüsü

### Kod:
```csharp
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
```

### Açıklama:
- `sayac` değişkeni 0 olarak başlatılmıştır.
- Kullanıcıdan bir `limit` değeri girmesi istenir.
- Koşul: `sayac` değeri `limit` değerine eşit veya daha küçük olduğu sürece döngü çalışır.
- Eğer kullanıcı **0 veya daha küçük bir değer** girerse, döngü çalışmaz çünkü koşul baştan sağlanmaz.
- Pozitif bir sayı girilirse, döngü başlangıç dahil, `limit` değerine kadar çalışır ve her seferinde bir çıktı üretir.

---

## Do While Döngüsü

### Kod:
```csharp
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
                Console.WriteLine("Ben bir Patika'lıyım!");
                sayac++;
            }
            while (sayac <= limit);
        }
    }
}
```

### Açıklama:
- `sayac` değişkeni 0 olarak başlatılmıştır.
- Kullanıcıdan bir `limit` değeri girmesi istenir.
- Döngü koşulu: `sayac` değeri `limit` değerine eşit veya daha küçük olduğu sürece çalışır.
- **Do While Döngüsü** öncelikle bir kez çalışır ve ardından koşulu kontrol eder. Bu nedenle, kullanıcı **0 veya daha küçük bir değer** girse bile döngü bir kez çalışacaktır.
- Pozitif bir sayı girilirse, döngü başlangıç dahil, `limit` değerine kadar çalışır.

---

## While ve Do While Arasındaki Farklar

| Özellik                  | While Döngüsü                              | Do While Döngüsü                            |
|--------------------------|-------------------------------------------|--------------------------------------------|
| Çalışma Şartı            | Koşul sağlanmadan döngü başlamaz.         | İlk işlem koşula bakılmadan gerçekleştirilir.|
| Kullanıcı 0 veya daha küçük değer girerse | Döngü hiç çalışmaz.                        | Döngü bir kez çalışır.                      |
| Kullanım Alanı           | Koşulun baştan sağlanması gerektiğinde    | En az bir kez çalışması gerektiğinde       |

---

Bu örnekler, C#'ta döngü yapılarının çalışma mantığını anlamanıza yardımcı olacaktır. Her iki döngü de farklı durumlarda kullanılabilir; ihtiyaçlarınıza uygun olanı seçebilirsiniz.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolymorphism
{




    // Polymorphismde amaç kalıtım yapılan sınıftan bazı değerleri alıp kullanabilmek
    // Bunu yaparken de override yani ezme işlemi uygulanır.
    // Aşağıda yapılmakta olan örnekte insan isimli bir sınıf olacak ve
    // bu sınıfın içerisinden tanımlı sanal bir metodumun yardımıyla arka plan rengi değiştirilmiştir.
    class insan
    {


        public virtual void change()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Title = "BU BİR ÖRNEKTİR";
            Console.WriteLine("");
            Console.WriteLine("BU EZİLMEDEN ÖNCEKİ TEXT");


        }


    }
}

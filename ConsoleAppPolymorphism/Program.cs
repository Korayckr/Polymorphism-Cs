using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolymorphism
{
    class Program
    {
        static void Main(String[] args)
        {
            EnglishPeople eng = new EnglishPeople();
            eng.change();

            Console.ReadKey();
        }


    }
}

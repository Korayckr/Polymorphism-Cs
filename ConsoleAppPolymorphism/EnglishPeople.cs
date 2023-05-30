using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolymorphism
{
    class EnglishPeople : insan
    {
        public override void change()
        {
            Console.Title = "Bu bir örnektir.";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello MR. and MSS. ....");
        }




    }
}

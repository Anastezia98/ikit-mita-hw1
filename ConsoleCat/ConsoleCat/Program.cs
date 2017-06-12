using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  ClassLibrary1;

namespace ConsoleCat
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2017,05,05);
            Cat cat_1 = new Cat("AS",date);
            Console.WriteLine("Данные о приобретаемом питомце\nИмя: {0}\nВозраст: {1}", cat_1.Name,cat_1.Age);
            cat_1.Feed();
            cat_1.Punish();
            cat_1.Punish();
            Console.WriteLine(cat_1.Color);
            Console.ReadKey();
        }
    }
}

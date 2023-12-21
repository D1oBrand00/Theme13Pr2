using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme13Pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edition ed1 = new Edition();
            //ed1.Name = "Известия";
            //ed1.Surname = "N";
            //ed1.Year = 1917;
            //Console.WriteLine($"{ed1.ToString()}\n");
            //Edition ed2 = new Edition("Ведомости", "N", 2000);
            //Console.WriteLine($"{ed2.ToString()}\n");
            //Edition ed3 = new Edition("Российская газета", "N", 1999);
            //Console.WriteLine($"{ed3.ToString()}\n  ");
            //Edition ed4 = new Edition("Известия", "N", 1960);
            //Console.WriteLine($"{ed4.ToString()}\n  ");
            //Console.Write("На сколько лет изменить год издания? ");
            //int changeyear = int.Parse(Console.ReadLine());
            //ed4.ChangeYear(changeyear);
            //Console.WriteLine($"{ed4.ToString()}\n  ");

            //Software sw1 = new Software("", "", true);
            //Console.WriteLine($"{sw1.ToString()}\n");
            //Software sw2 = new Software("Word", "Microsoft", true);
            //Console.WriteLine($"{sw2.ToString()}\n");
            //Software sw3 = new Software("Office", "Microsoft", true);
            //sw3.ChangeFree();
            //Console.WriteLine($"{sw3.ToString()}");
            //sw3.FreeOrPay();


            banknote n1 = new banknote("Рубль", 100, 3);
            Console.WriteLine($"{n1.ToString()}\n");
            banknote n2 = new banknote("Доллар", 50, 5);
            Console.WriteLine($"{n2.ToString()}\n");
            banknote n3 = new banknote("Евро", 10, 7);
            Console.Write("На какое число изменить количество купюр? ");
            int changecount = int.Parse(Console.ReadLine());
            n3.ChangeCount(changecount);
            Console.WriteLine($"{n3.ToString()}\n");
            banknote n4 = new banknote("Рубль", 2500, 7);
            Console.Write("Цена покупки - ");
            int cost = int.Parse(Console.ReadLine());
            n4.Comparation(cost);

            Console.Read();
        }
    }
}

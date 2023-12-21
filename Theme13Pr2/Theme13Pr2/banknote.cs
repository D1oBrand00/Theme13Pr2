using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme13Pr2
{
    class banknote
    {
        string name;
        int nominal;
        int count;

        public string Name
        {
            get { return name; }
            set
            {
                name = (value == "") ? "Название не введено" : value;
            }
        }
        public int Nominal
        {
            get { return nominal; }
            set
            {
                nominal = (value < 0) ? 0 : value;
            }
        }
        public int Count
        {
            get { return count; }
            set
            {
                count = (value < 0) ? 0 : value;
            }
        }
        public banknote() { }
        public banknote(string name, int nominal, int count)
        {
            this.Name = name;
            this.Nominal = nominal;
            this.Count = count;
        }
        public override string ToString()
        {
            return $"Название - {name}\nНоминал - {nominal}\nКоличество - {count}";
        }
        public void ChangeCount(int changecount)
        {
            this.Count = count + changecount;
        }
        public void Comparation(int cost)
        {
            Console.WriteLine((nominal * count >= cost) ? "Суммы денег достаточно для покупки" : "Суммы денег не достаточно для покупки");
        }
    }
}

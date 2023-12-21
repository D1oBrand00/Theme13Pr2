using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme13Pr2
{
    class Software
    {
        string name;
        string manufacturer;
        bool free;

        public string Name
        {
            get { return name; }
            set
            {
                name = (value == "") ? "Имя не введено" : value;
            }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                manufacturer = (value == "") ? "Производитель не введен" : value;
            }
        }
        public bool Free
        {
            get { return free; }
            set
            {
                free = value;
            }
        }
        public Software() { }
        public Software(string name, string manufacturer, bool free)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Free = free;
        }
        public override string ToString()
        {
            return $"Название - {name}\nПроизводитель - {manufacturer}\nБесплатное - {free}";
        }
        public void ChangeFree()
        {
            free = (free == true) ? false : true;
        }
        public void FreeOrPay()
        {
            string freeorpay = (free == true) ? "ПО является бесплатным продуктом" : "ПО не является бесплатным продуктом";
            Console.WriteLine(freeorpay);
        }
    }
}

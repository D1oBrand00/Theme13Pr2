using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme13Pr2
{
 
        /// <summary>
        /// Класс, описывающий издание
        /// </summary>
        class Edition
        {
            /// <summary>
            /// Поле названия издания
            /// </summary>
            string name;
            /// <summary>
            /// Поле фамилии автора
            /// </summary>
            string surname;
            /// <summary>
            /// Поле значения года издания
            /// </summary>
            int year;
            public string Name
            {
                get { return name; }
                set
                {
                name = (value == "") ? "Имя не введено" : value;
                }
            }

            public string Surname
            {
                get { return surname; }
                set
                {
                surname = (value == "") ? "Фамилия не введена" : value;
                }
            }
            public int Year
            {
                get { return year; }
                set
                {
                    if (value < 0 || value < 1900 || value > 2023)
                    {
                        Console.WriteLine("Неверный год");
                    }
                    else
                    {
                        year = value;
                    }

                }
            }

            public Edition() { }
            public Edition(string name, string surname, int year)
            {
                this.Name = name;
                this.Surname = surname;
                this.Year = year;
            }
            public override string ToString()
            {
                return $"Название издания - {name}\nФамилия автора - {surname}\nГод публикации издания - {year}";
            }
            public void ChangeYear(int changeyear)
            {
                this.Year = year + changeyear;
            }

        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Gates : door
    {
        private double Width;//Ширина ворот
        private double Price;//Цена ворот
        private string Owner;//Владелец ворот
        private string Manufacturer;//производитель ворот

        public Gates()
        {
            Width = 0;
            Price = 0;
            Owner = "";
            Manufacturer = "";
        }
        public Gates(door door1, double width, double price,
            string owner, string manufacturer) : base(door1)
        {
            Width = width;
            Price = price;
            Owner = owner;
            Manufacturer = manufacturer;
        }
        public double prise_convert(string currency)
        {
            if (currency == "dolor")
            {
                return Price / 96.5;
            }
            else if (currency == "euro")
            {
                return Price / 104;
            }
            else if (currency == "yane")
            {
                return Price / 13.5;
            }
            else
            {
                Console.WriteLine("Не конвертируем");
            }
            return Price;
        }
        public bool truck()
        {
            if ((Width >= 4) && (Open == true))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return ("Ворота открвыты: " + Open +
                "\nВорота зафиксирована: " + Lock +
                "\nШиринка ворот: " + Width +
                " м.\nЦена ворот: " + Price +
                "\nХозяин ворот: " + Owner +
                "\nИзготовитель ворот: " + Manufacturer);
        }
    }
}

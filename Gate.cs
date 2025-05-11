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
        private double _width;//Ширина ворот
        private double _price;//Цена ворот
        private string _owner;//Владелец ворот
        private string _manufacturer;//производитель ворот

        public Gates()
        {
            _width = 0;
            _price = 0;
            _owner = "";
            _manufacturer = "";
        }

        
        public Gates(door door1, double width, double price,
            string owner, string manufacturer) : base(door1)
        {
            _width = width;
            _price = price;
            _owner = owner;
            _manufacturer = manufacturer;
        }

        
        public double PriseConvert(string currency)
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

        
        public bool Truck()
        {
            if ((Width >= 4) && (op == true))
            {
                return true;
            }
            return false;
        }

        
        public override string ToString()
        {
            return ("Ворота открвыты: " + op +
                "\nВорота зафиксирована: " + lo +
                "\nШиринка ворот: " + Width +
                " м.\nЦена ворот: " + Price +
                "\nХозяин ворот: " + Owner +
                "\nИзготовитель ворот: " + Manufacturer);
        }
    }
}

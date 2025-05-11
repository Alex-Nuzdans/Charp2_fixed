using System;
using ConsoleApp1;
namespace Main
{
    class HelloWorld
    {
        static void Main()
        {
            Console.WriteLine("Введите информацию о каком классе вы ищете(1, 2, 3):");
            var S = Console.ReadLine();
            if (S == "1")
            {
                var door1 = new door();
                Console.WriteLine("Введите ширину ворот");
                double width = 1;
                double price = 1;
                try
                {
                    width = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректные данные! Задано базавое значение: 1");
                }
                Console.WriteLine("Введите цену ворот");
                try
                {
                    price = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректные данные! Задано базавое значение: 1");
                }
                Console.WriteLine("Введите владельца ворот");
                var owner = Console.ReadLine();
                Console.WriteLine("Введите производителя ворот");
                var manufacturer = Console.ReadLine();
                var Gate = new Gates(door1, width, price, owner, manufacturer);
                Console.WriteLine(Gate);
                if (Gate.Close())
                {
                    Console.WriteLine("Ворота открыты!");
                }
                else
                {
                    Console.WriteLine("Заперто!");
                }
                if (Gate.Truck())
                {
                    Console.WriteLine("Грузовик проедет!");
                }
                else
                {
                    Console.WriteLine("Грузовик не проедет!");
                }
                Console.WriteLine("Введите валюту(dolor, euro, yane):");
                Console.WriteLine("Цена равна: " +
                    (Gate.PriseConvert(Console.ReadLine())));
            }
            else if (S == "2")
            {
                Console.WriteLine("Введите координаты первой прямой");
                double x1 = 1;
                double y1 = 1;
                double x2 = 1;
                double y2 = 1;
                try
                {
                    x1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректные данные! Задано базавое значение: 1");
                }
                try
                {
                    y1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректные данные! Задано базавое значение: 1");
                }
                Console.WriteLine("Введите координаты второй прямой");
                try
                {
                    x2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректные данные! Задано базавое значение: 1");
                }
                try
                {
                    y2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректные данные! Задано базавое значение: 1");
                }
                var line1 = new LineSegment(x1, y1);
                var line2 = new LineSegment(x2, y2);
                if (line1.intersection(line2))
                {
                    Console.WriteLine("Они пересекаются!");
                }
                else
                {
                    Console.WriteLine("Они не пересекаются!");
                }
            }
            else if (S == "3")
            {
                Console.WriteLine("Введите координаты первой прямой");
                double x1 = 1;
                double y1 = 1;
                double x2 = 1;
                double y2 = 1;
                try
                {
                    x1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректные данные! Задано базавое значение: 1");
                }
                try
                {
                    y1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректные данные! Задано базавое значение: 1");
                }
                Console.WriteLine("Введите координаты второй прямой");
                try
                {
                    x2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректные данные! Задано базавое значение: 1");
                }
                try
                {
                    y2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректные данные! Задано базавое значение: 1");
                }
                var line1 = new LineSegment2(x1, y1);
                var line2 = new LineSegment2(x2, y2);
                Console.WriteLine("Длинна первого отрезка" + !line1);
                Console.WriteLine("Координаты первого отрезка");
                line1.print();
                line1++;
                Console.WriteLine("Расшиернные координаты первого отрезка");
                line1.print();
                Console.WriteLine("Введите целое число: ");
                var x = 1;
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректные данные! Задано базавое значение: 1");
                }
                line1 = line1 - x;
                Console.WriteLine("Координаты первого отрезка(x сокращён)");
                line1.print();
                Console.WriteLine("Введите целое число: ");
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректные данные! Задано базавое значение: 1");
                    x = 1;
                }
                line1 = x - line1;
                Console.WriteLine("Координаты первого отрезка(y сокращён)");
                line1.print();
                int z1 = line1;
                Console.WriteLine("Конвертация через переменную int: " + z1);
                double z2 = (double)line1;
                Console.WriteLine("Конвертация через переменную double: " + z2);
                if (line1 > line2)
                {
                    Console.WriteLine("Отрезки пересекаются!");
                }
                else
                {
                    Console.WriteLine("Отрезки не пересекаются!");
                }
            }
        }
    }
}

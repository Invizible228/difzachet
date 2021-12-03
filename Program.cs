using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;

namespace DifEx
{
    class Program
    {
        public static void Removing(int element)
        {
            List<string> l = new List<string>();
            l.RemoveAt(element);
        }
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("File.txt");
            

            List<Tour> tours = new List<Tour>()

            {
                new Tour { identificator = 001, nameofthcountry = "Турция" },
                new Tour { identificator = 005, nameofthcountry = "Польша" },
                new Tour { identificator = 003, nameofthcountry = "Россия" },
                new Tour { identificator = 002, nameofthcountry = "Швеция" },
                new Tour { identificator = 004, nameofthcountry = "Германия" }
            };

            List<Hotel> hotels = new List<Hotel>()
            {
                new Hotel{identificator = 002, nameofthehotel = "Лагуна", price = 3000, typeoflocalization = "Долго"  },
                new Hotel{identificator = 001, nameofthehotel = "Каравелла", price = 2500, typeoflocalization = "Недолго"  },
                new Hotel{identificator = 004, nameofthehotel = "Фавелла", price = 1500, typeoflocalization = "Долго"  },
                new Hotel{identificator = 003, nameofthehotel = "Шале", price = 3500, typeoflocalization = "Долго"  },
                new Hotel{identificator = 005, nameofthehotel = "Бриз", price = 6000, typeoflocalization = "Недолго"  }
            };
            Console.WriteLine("Первый список:");
            foreach (var item in tours)
            {
                Console.WriteLine(item.identificator + " " + item.nameofthcountry);
            }
            Console.WriteLine("Второй список:");
            foreach (var item in hotels)
            {
                Console.WriteLine(item.identificator + " " + item.nameofthehotel + " " + item.price + " " +item.typeoflocalization);
            }
            Console.WriteLine("Как вы хотите отсортировать?");
            Console.WriteLine("Если хотите отсортировать по возрастанию, нажмите 1, если по убыванию - 2");
            try
            {
                int key = Convert.ToInt32(Console.ReadLine());
                if (key == 1)
                {
                    Console.WriteLine("Сортирую...");
                    Thread.Sleep(1000);
                    var hordered = hotels.OrderBy(x => x.price);
                    var tordered = tours.OrderBy(x => x.identificator);
                    Console.WriteLine("1 список - цена");
                    foreach (var item in hordered)
                    {
                        Console.WriteLine(item.price);
                    }
                    Console.WriteLine("2 список - идентификатор");
                    foreach (var item in tordered)
                    {
                        Console.WriteLine(item.identificator);
                    }
                }
                else if (key == 2)
                {
                    Console.WriteLine("Сортирую...");
                    Thread.Sleep(1000);
                    var hordereddesc = hotels.OrderByDescending(x => x.price);
                    var tordereddesc = tours.OrderByDescending(x => x.identificator);
                    Console.WriteLine("1 список - цена");
                    foreach (var item in hordereddesc)
                    {
                        Console.WriteLine(item.price);
                    }
                    Console.WriteLine("2 список - идентификатор");
                    foreach (var item in tordereddesc)
                    {
                        Console.WriteLine(item.identificator);
                    }
                }
            }
            catch { Console.WriteLine("Ошибка! Попробуйте еще раз."); }
            Console.WriteLine("Вы хотите удалить элементы?");
            Console.WriteLine("Если хотите удалить, нажмите 1, если нет - 2, если хотите удалить через метод - 3");
            int key2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (key2 == 1)
                {
                    Console.WriteLine("Какой элемент хотите удалить?");
                    int element = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Удаляю...");
                    Thread.Sleep(1000);
                    tours.RemoveAt(element);
                    hotels.RemoveAt(element);
                    foreach (var item in tours)
                    {
                        if (element == 0)
                        {
                            Console.WriteLine(item.nameofthcountry);
                        }
                        else if (element == 1)
                        {
                            Console.WriteLine(item.identificator);
                        }
                    }
                    Console.WriteLine("Второй список:");
                    foreach (var item in hotels)
                    {
                        if (element == 0)
                        {
                            Console.WriteLine(item.nameofthehotel + " " + item.price + " " + item.typeoflocalization);
                        }
                        if (element == 1)
                        {
                            Console.WriteLine(item.identificator + " " + item.price + " " + item.typeoflocalization);
                        }
                        if (element == 2)
                        {
                            Console.WriteLine(item.identificator + " " + item.nameofthehotel + " " + item.typeoflocalization);
                        }
                        if (element == 3)
                        {
                            Console.WriteLine(item.identificator + " " + item.nameofthehotel + " " + item.price);
                        }
                    }
                }
                else if (key2 == 2)
                {
                    Console.WriteLine("Спасибо за использование!");
                }
                else if (key2 == 3)
                {
                    Console.WriteLine("Какой элемент хотите удалить?");
                    int element = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Удаляю...");
                    Thread.Sleep(1000);
                    Program.Removing(element);
                    tours.RemoveAt(element);
                    hotels.RemoveAt(element);
                    foreach (var item in tours)
                    {
                        if (element == 0)
                        {
                            Console.WriteLine(item.nameofthcountry);
                        }
                        else if (element == 1)
                        {
                            Console.WriteLine(item.identificator);
                        }
                    }
                    Console.WriteLine("Второй список:");
                    foreach (var item in hotels)
                    {
                        if (element == 0)
                        {
                            Console.WriteLine(item.nameofthehotel + " " + item.price + " " + item.typeoflocalization);
                        }
                        if (element == 1)
                        {
                            Console.WriteLine(item.identificator + " " + item.price + " " + item.typeoflocalization);
                        }
                        if (element == 2)
                        {
                            Console.WriteLine(item.identificator + " " + item.nameofthehotel + " " + item.typeoflocalization);
                        }
                        if (element == 3)
                        {
                            Console.WriteLine(item.identificator + " " + item.nameofthehotel + " " + item.price);
                        }
                    }
                }
            }
            catch { Console.WriteLine("Ошибка! Попробуйте еще раз."); }            
        }
    }
}

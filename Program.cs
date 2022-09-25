using System;
using Currency;
using Check;

namespace Converter
{
    class Converter
    {
        static void Main(string[] args)
        {
            Console.Write($"Какую валюту вы желаете приобрести? \n{RYB.name} - 1 \n{USD.name} - 2 \n{EUR.name} - 3\n");
            ConsoleKey Change = Console.ReadKey().Key;
            if (Change != ConsoleKey.NumPad1 && Change != ConsoleKey.NumPad2 && Change != ConsoleKey.NumPad3)
            {
                Console.WriteLine("Ошибка! Неверный ввод данных.");
                return;
            }
            else

            {
                Console.WriteLine("Сколько валюты вы желаете приобрести?");
                double kolichestvo = double.Parse(Console.ReadLine());
                double oplata;
                switch (Change)
                {
                    case ConsoleKey.NumPad1:
                        {
                            oplata = RYB.kurs * kolichestvo;
                            Console.WriteLine("К оплате - " + oplata);              
                            Console.WriteLine("Желаете получить чек?\nДа - 1\nНет - 2");
                            ConsoleKey consoleKey = Console.ReadKey().Key;
                                switch (consoleKey)
                                {
                                    case ConsoleKey.NumPad1:
                                        {
                                            Console.WriteLine("Введите ваше имя.");
                                            Person.name = Console.ReadLine();
                                            Console.WriteLine("Введите вашу фамилию.");
                                            Person.surname = Console.ReadLine();
                                            Console.WriteLine("Введите ваш возраст.");
                                            Person.age = Console.ReadLine();
                                            {
                                                Console.WriteLine($"{Person.name}\n{Person.surname}\n{Person.age}Лет");
                                                Console.WriteLine($"Приобрел(а) - {kolichestvo} {RYB.name}" +
                                                    $"\nЗаплатив - {oplata} {BYN.name}\n{DateTime.Now}");
                                            }
                                            break;
                                        }
                                    case ConsoleKey.NumPad2:
                                        {
                                            Console.WriteLine("Спасибо за покупку!!!");
                                            break;
                                        }

                                    default:
                                        {
                                            Console.WriteLine("Ошибка!");
                                            break;
                                        }
                                }
                            } break;
                        
                    
                           case ConsoleKey.NumPad2:
                        {
                            oplata = USD.kurs * kolichestvo;
                            Console.WriteLine("К оплате - " + oplata);
                            
                            Console.WriteLine("Желаете получить чек?\nДа - 1\nНет - 2");
                            ConsoleKey consoleKey = Console.ReadKey().Key;
                            switch (consoleKey)
                            {
                                case ConsoleKey.NumPad1:
                                    {
                                        Console.WriteLine("Введите ваше имя.");
                                        Person.name = Console.ReadLine();
                                        Console.WriteLine("Введите вашу фамилию.");
                                        Person.surname = Console.ReadLine();
                                        Console.WriteLine("Введите ваш возраст.");
                                        Person.age = Console.ReadLine();
                                        {
                                            Console.WriteLine($"{Person.name}\n{Person.surname}\n{Person.age}Лет");
                                            Console.WriteLine($"Приобрел(а) - {kolichestvo} {RYB.name}" +
                                                $"\nЗаплатив - {oplata} {BYN.name}\n{DateTime.Now}");
                                        }
                                        
                                        break;
                                    }
                                case ConsoleKey.NumPad2:
                                    {
                                        Console.WriteLine("Спасибо за покупку!!!");
                                        break;
                                    }

                                default:
                                    {
                                        Console.WriteLine("Ошибка!");
                                        break;
                                    }
                            }break;
                        }
                    
                    
                    case ConsoleKey.NumPad3:
                        {
                            oplata = EUR.kurs * kolichestvo;
                            Console.WriteLine("К оплате - " + oplata);
                           
                            Console.WriteLine("Желаете получить чек?\nДа - 1\nНет - 2");
                            ConsoleKey consoleKey = Console.ReadKey().Key;
                                switch (consoleKey)
                                {
                                    case ConsoleKey.NumPad1:
                                        {
                                            Console.WriteLine("Введите ваше имя.");
                                            Person.name = Console.ReadLine();
                                            Console.WriteLine("Введите вашу фамилию.");
                                            Person.surname = Console.ReadLine();
                                            Console.WriteLine("Введите ваш возраст.");
                                            Person.age = Console.ReadLine();
                                            {
                                                Console.WriteLine($"{Person.name}\n{Person.surname}\n{Person.age}Лет");
                                                Console.WriteLine($"Приобрел(а) - {kolichestvo} {RYB.name}" +
                                                    $"\nЗаплатив - {oplata} {BYN.name}\n{DateTime.Now}");
                                            }
                                            break;
                                        }
                                    case ConsoleKey.NumPad2:
                                        {
                                            Console.WriteLine("Спасибо за покупку!!!");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Ошибка!");
                                            break;
                                        }
                                }break;
                            
                            }
                        }
                
                }
                
        }
    }
}
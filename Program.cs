using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем переменную для завершения программы и присваиваем значение
            bool endApp = false;

            // выведем название программы
            Console.WriteLine("**********************************\r");
            Console.WriteLine("*  Консольный калькулятор на C#  *\r");
            Console.WriteLine("**********************************\r");

            do
            {
                // выводим список операций
                Console.WriteLine("\nВыберите операцию из списка:");
                Console.WriteLine("\t1 - Сложение двух чисел");
                Console.WriteLine("\t2 - Вычесть из первого второе");
                Console.WriteLine("\t3 - Перемножить два числа");
                Console.WriteLine("\t4 - Разделить первое на второе");
                Console.WriteLine("\t5 - Возвести первое число в степень N - (второе число)");
                Console.WriteLine("\t6 - Найти квадратный корень из числа");
                Console.WriteLine("\t7 - Найти 1% от числа");
                Console.WriteLine("\t8 - Найти факториал числа");
                Console.WriteLine("\t9 - Выйти из программы");
                Console.WriteLine("\nВведите свой выбор: ");

                //создаем переменную и организуем пользовательский ввод c проверкой что введено число
                int op;
                while (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Ошибка ввода! Введите номер операции:");
                }
                //если операция с 1 по 5
                if (op == 1 || op == 2 || op == 3 || op == 4 || op == 5)
                {
                    // создаем переменные и задаем им пустые значения
                    string numInput1 = "";
                    string numInput2 = "";

                    // просим ввести первое число
                    Console.WriteLine("\nВведите первое число и нажмите enter: ");
                    numInput1 = Console.ReadLine();
                    //проверка на корретный ввод, если введено не число, просим ввести заново
                    double cleanNum1 = 0;
                    while (!double.TryParse(numInput1, out cleanNum1))
                    {
                        Console.WriteLine("Ошибка ввода! Введите первое число: ");
                        numInput1 = Console.ReadLine();
                    }

                    // просим ввести второе число
                    Console.WriteLine("\nВведите второе число и нажмите enter: ");
                    numInput2 = Console.ReadLine();
                    //проверка на корретный ввод, если введено не число, просим ввести заново
                    double cleanNum2 = 0;
                    while (!double.TryParse(numInput2, out cleanNum2))
                    {
                        Console.WriteLine("Ошибка ввода! Введите второе число: ");
                        numInput2 = Console.ReadLine();
                    }

                    // создаем переменные, преобразуем значения к типу double и присваиваем введенные ранее числа
                    double num1 = Convert.ToDouble(numInput1);
                    double num2 = Convert.ToDouble(numInput2);

                    //используя оператор выбора switch производим вычисления в соотвествии с выбором пользователя
                    switch (op)
                    {
                        case 1: //сумма
                            Console.WriteLine($"\n{num1} + {num2} = " + (num1 + num2));
                            Console.WriteLine("----------------------------\n");
                            break;
                        case 2: //вычитание
                            Console.WriteLine($"\n{num1} - {num2} = " + (num1 - num2));
                            Console.WriteLine("----------------------------\n");
                            break;
                        case 3: //произведение
                            Console.WriteLine($"\n{num1} * {num2} = " + (num1 * num2));
                            Console.WriteLine("----------------------------\n");
                            break;
                        case 4: //деление
                            while (num2 == 0) //проверяем что бы не было деления на ноль
                            {
                                Console.WriteLine("\nДеление на ноль запрещено!");

                                // просим повторно ввести второе число
                                Console.WriteLine("\nВведите второе число и нажмите enter: \n");
                                num2 = Convert.ToDouble(Console.ReadLine());
                            }
                            Console.WriteLine($"\n{num1} / {num2} = " + (num1 / num2));
                            Console.WriteLine("----------------------------\n");
                            break;
                        case 5: // возведение в степень
                            // создаем переменные, перобразуем значения к типу int и присваиваем значения ранее введенных чисел
                            int num1Int = Convert.ToInt32(num1);
                            int num2Int = Convert.ToInt32(num2);
                            Console.WriteLine($"\n{num1Int} ^ {num2Int} = " + Math.Pow(num1Int, num2Int));
                            Console.WriteLine("----------------------------\n");
                            break;
                        default: // дефолтное значение
                            Console.WriteLine("\nОшибка, невозможно произвести вычисление!\n");
                            op = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                // если операция с 6 по 8
                else if (op == 6 || op == 7 || op == 8)
                {
                    // создаем переменную
                    string numInput = "";

                    // просим ввести число
                    Console.WriteLine("\nВведите число и нажмите enter: ");
                    numInput = Console.ReadLine();
                    // проверяем корректность ввода, если не число просим ввести заново
                    double cleanNum = 0;
                    while (!double.TryParse(numInput, out cleanNum))
                    {
                        Console.WriteLine("\nОшибка ввода! введите число: ");
                        numInput = Console.ReadLine();
                    }
                    // создаем переменную, преобразуем значение к типу double и присваиваем введеное ранее число
                    double num = Convert.ToDouble(numInput);

                    switch (op)
                    {
                        case 6: // квадратный корень
                            Console.WriteLine($"\nКвадратный корень из {num} = " + Math.Sqrt(num));
                            Console.WriteLine("----------------------------\n");
                            break;
                        case 7: // 1% от числа
                            Console.WriteLine($"\n1% от {num} = " + (num / 100));
                            Console.WriteLine("----------------------------\n");
                            break;
                        case 8: // факториал
                            long fact = 1;
                            if (fact == 0)
                            {
                                Console.WriteLine($"\nФакториал числа 0 = 1");
                            }
                            else
                            {
                                for (int i = 1; i <= num; i++)
                                {
                                    fact *= i;
                                }
                                Console.WriteLine($"\nФакториал числа {num} = " + (fact));
                            }
                            break;
                        default: // дефолтное значение
                            Console.WriteLine("\nОшибка, невозможно произвести вычисление!\n");
                            op = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                // если ввели 9 завершаем программу
                else if (op == 9)
                {
                    endApp = true;
                    Console.WriteLine("\n"); // сделаем отступ
                }
                // если ввели не существующую команду
                else
                {
                    Console.WriteLine("Такой операции не существует!");
                }
            } while (!endApp);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DZ1_19._01._2021_
{
    class Program
    {   
        static void Main(string[] args)
        {
            int pNumber;
            String s;
            Console.WriteLine("ДЗ1 на дату 19.01.2021 \nВВодите номер задание для проверки(1-6). Чтобы выйти вводите 'q'!");
            s = Console.ReadLine();
            while (true)
            {
                if (s == "q") break;
                else if (Int32.TryParse(s, out pNumber))
                {
                    switch (pNumber)
                    {
                        case 1:
                            double a1, b1;
                            Console.Write("Вводите первое число:");
                            a1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Вводите второе число:");
                            b1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Среднее геометрическое чисел {0} и {1} равен:{2:F4}", a1, b1, Math.Sqrt(a1 * b1));
                            break;

                        case 2:
                            double a, b, c;
                            Console.Write("Вводите A: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Вводите B: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Вводите C: ");
                            c = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("AC = {0}", Math.Abs(a - c));
                            Console.WriteLine("BC = {0}", Math.Abs(b - c));
                            Console.WriteLine("AC + BC = {0:F3}", Math.Abs(a - c) + Math.Abs(b - c));
                            break;

                        case 3:
                            double x1, x2, y1, y2;
                            Console.Write("Вводите x1, y1: ");
                            String ss = Console.ReadLine();
                            x1 = Convert.ToDouble(ss.Split(' ')[0]);
                            y1 = Convert.ToDouble(ss.Split(' ')[1]);
                            Console.Write("Вводите x2, y2: ");
                            ss = Console.ReadLine();
                            x2 = Convert.ToDouble(ss.Split(' ')[0]);
                            y2 = Convert.ToDouble(ss.Split(' ')[1]);
                            double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
                            Console.WriteLine("Результат: {0:F2}", result);
                            break;

                        case 4:
                            Console.Write("Число: ");
                            string temp = Console.ReadLine();
                            Console.WriteLine("Результат: "+temp[1]+temp[0]);
                            int n = Convert.ToInt32(temp);
                            int nn = (n % 10) * 10 + n / 10;
                            Console.WriteLine("Число: {0}\nрезультат: {1}",n,nn);
                            break;

                        case 5:
                            Console.Write("N = ");
                            int N = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Резулаьтат {0}", N/60);
                            break;
                        case 6:
                            Console.Write("K = ");
                            int k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Номер дня недели: {0}", k%7);
                            break;
                        default:

                            break;

                    }; 
                    Console.WriteLine("Чтобы продолжить еще раз вводите номер задачи(1-6). Чтобы выйти вводите 'q'.");

                }
                else
                {
                    Console.WriteLine("Вы ввели неправильный номер задачи. Вводите еще раз(1-6). Чтобы выйти вводите 'q'.");
                }
                    s = Console.ReadLine();
            }
            Console.WriteLine("Приходите еще!");
            Console.ReadLine();
        }
    }
}






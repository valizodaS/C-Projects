using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_21._01._2021_
{
    class Program
    {
        static void Main(string[] args)
        {
            int pNumber;
            String s;
            Console.WriteLine("ДЗ1 на дату 19.01.2021 \nВводите номер задание для проверки(1-6). Чтобы выйти вводите 'q'!");
            s = Console.ReadLine();
            while (true)
            {
                if (s == "q") break;
                else if (Int32.TryParse(s, out pNumber))
                {
                    switch (pNumber)
                    {
                        case 1:
                            int a, b;
                            Console.Write("A: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("B: ");
                            b = Convert.ToInt32(Console.ReadLine());
                            if (a == b) 
                            {
                                a = 0;
                                b = 0;
                                Console.WriteLine("Они равны! \nA = {0}\nB = {1}", a, b);
                            }
                            else
                            {
                                a = Math.Max(a, b);
                                b = Math.Max(a, b);
                                Console.WriteLine("A = {0}\nB = {1}", a, b);
                            }
                            break;
                        case 2:
                            double operand1, operand2;
                            String sign;
                            Console.Write("Operand1 = ");
                            operand1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Operand2 = ");
                            operand2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Sign : ");
                            sign = Console.ReadLine();
                            switch (sign)
	                        {
                                case "+":
                                    Console.WriteLine("{0} + {1} = {2}", operand1, operand2, operand2 + operand1);
                                    break;
                                case "-":
                                    Console.WriteLine("{0} - {1} = {2}", operand1, operand2, operand1 - operand2);
                                    break;
                                case "*":
                                    Console.WriteLine("{0} * {1} = {2}", operand1, operand2, operand2 * operand1);
                                    break;
                                case "/":
                                    if (operand2 == 0) {
                                        Console.WriteLine("Попытка деление на ноль. НЕЛЬЗЯ!!!");
                                        break;
                                    }
                                    Console.WriteLine("{0} / {1} = {2}", operand1, operand2, operand1 / operand2);
                                    break;
                                default:
                                    Console.WriteLine("Такая операция не предувидено!");
                                    break;
	                        }
                            break;
                        case 3:
                            Console.Write("A number please(0-100): ");
                            int nn = Convert.ToInt32(Console.ReadLine());
                            if (nn >= 0 && nn <= 14) 
                            {
                                Console.WriteLine("Ваше число назодится в 1-ом интервле. [0-14]");
                            }
                            else if ((nn >= 15 && nn <= 35))
                            {
                                Console.WriteLine("Ваше число назодится в 2-ом интервле. [15-35]");
                            }
                            else if ((nn >= 16 && nn <= 50))
                            {
                                Console.WriteLine("Ваше число назодится в 2-ом интервле. [36-50]");
                            }
                            else if ((nn >= 50 && nn <= 100))
                            {
                                Console.WriteLine("Ваше число назодится в 2-ом интервле. [50-100]");
                            }
                            else
                            {
                                Console.WriteLine("Ваше число не входит ни в какой данных интервалов!");
                            }
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


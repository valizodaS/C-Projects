using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_23._01._2021_
{
    class Program
    {
        static void Main(string[] args)
        {
            int pNumber;
            String s;
            Console.WriteLine("ДЗ3.1 на дату 23.01.2021 \nВводите номер задание для проверки(1-3). Чтобы выйти вводите 'q'!");
            s = Console.ReadLine();
            while (true)
            {
                if (s == "q") break;
                else if (Int32.TryParse(s, out pNumber))
                {
                    switch (pNumber)
                    {
                        case 1:
                            int a, b, sum = 0;
                            string str = "";
                            Console.Write("Вводите A:");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Вводите B:");
                            b = Convert.ToInt32(Console.ReadLine());
                            for (int i = a+1; i < b; i++)
                            {
                                sum += i;
                                if (i % 2 == 1)
                                {
                                    str += " " + i.ToString();
                                }
                            }
                            Console.WriteLine("Сумма всех чисел от {0} до {1} равен:{2}", a, b, sum);
                            Console.WriteLine("Все нечетные числа от {0} до {1}: {2} ", a,b,str);
                            
                            break;
                        case 2:
                            Console.Write("Вводите высоту фигур: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            drawRectangle(n);
                            drawRightTriangle(n);
                            drawEquilateralTringle(n);
                            drawRhomb(n);
                            break;
                        case 3:
                            double P;
                            int k=0;
                            Console.Write("Вводите P: ");
                            P = Convert.ToDouble(Console.ReadLine());
                            double summ = 1000;
                            while (summ < 1100) 
                            {
                                summ += summ * P / 100.0;
                                k++;
                            }
                            Console.WriteLine("Через {0} месяцов сумма превысит 1100руб. и она равно  = {1:F2}\n",k,summ);
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
        public static void drawRectangle(int n) 
        {
            string substr = "*";
            Console.WriteLine("Прямоугольник:\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("* ");
                if (i > 0 && i <  n - 1) substr += "  ";
            }
            substr += " *";
            Console.WriteLine("");
            for (int i = 1; i < n - 1; i++)
            {
                Console.WriteLine(substr);
            }
            for (int i = 0; i <  n; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("\n");
        }
        public static void drawRightTriangle(int n)
        {
            string s="";
            Console.WriteLine("Правильный треугольник: \n*");
            for (int i = 0; i < n-1; i++)
            {
                s = "*";
                for (int j = 0; j < i; j++)
                {
                    s += " ";
                }
                s += "*";
                Console.WriteLine(s);
            }
            s = "";
            for (int i = 0; i <= n; i++)
            {
                s += "*";
            }
            Console.WriteLine(s+"\n");
        }
        public static void drawEquilateralTringle(int n)
        {
            string s="";
            Console.WriteLine("Равносторонный треугольник: \n");
            for (int i = 0; i < n-1; i++)
            {
                s = "";
                for (int j = 0; j < n+i; j++)
                {
                    if (j < n - 1 - i) s += " ";
                    else if (j == n - 1 - i) s += "*";
                    else if (j > n - 1 - i && j < n + i - 1) s += " ";
                    else s += "*";
                }
                Console.WriteLine(s);
            }
            for (int i = 0; i < n*2-1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine( "\n");
        }
        public static void drawRhomb(int n)
        {
            string s = "";
            Console.WriteLine("Ромб: \n");
            for (int i = 0; i < n - 1; i++)
            {
                s = "";
                for (int j = 0; j < n + i; j++)
                {
                    if (j < n - 1 - i) s += " ";
                    else if (j == n - 1 - i) s += "*";
                    else if (j > n - 1 - i && j < n + i - 1) s += " ";
                    else s += "*";
                }
                Console.WriteLine(s);
            }
            for (int i = n-3; i >= 0; i--)
            {
                s = "";
                for (int j = 0; j < n + i; j++)
                {
                    if (j < n - 1 - i) s += " ";
                    else if (j == n - 1 - i) s += "*";
                    else if (j > n - 1 - i && j < n + i - 1) s += " ";
                    else s += "*";
                }
                Console.WriteLine(s);
            }
            Console.WriteLine("");
        }
    }
}


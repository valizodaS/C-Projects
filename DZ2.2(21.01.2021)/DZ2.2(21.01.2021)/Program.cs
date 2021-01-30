using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2._2_21._01._2021_
{
    class Program
    {
        static void Main(string[] args)
        {
            int pNumber;
            String s;
            Console.WriteLine("ДЗ2.2 на дату 21.01.2021 \nВводите номер задание для проверки(1-3). Чтобы выйти вводите 'q'!");
            s = Console.ReadLine();
            while (true)
            {
                if (s == "q") break;
                else if (Int32.TryParse(s, out pNumber))
                {
                    switch (pNumber)
                    {
                        case 1:
                            double a;
                            Console.Write("Сумма покупки: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            if(a>=500)a += a*3.0/100.0;
                            else if (a>=1000) a+= a*5.0/100.0;
                            Console.WriteLine("Сумма покупки с учетом скидок = {0:F2}",a);
                            break;
                        case 2:
                            double n1, n2, n3, n4;
                            String ss = Console.ReadLine();
                            n1 = Convert.ToDouble(ss.Split(' ')[0]);
                            n2 = Convert.ToDouble(ss.Split(' ')[1]);
                            n3 = Convert.ToDouble(ss.Split(' ')[2]);
                            n4 = Convert.ToDouble(ss.Split(' ')[3]);
                            if (n1 < n2 && n2 < n3 && n3 < n4) 
                            {
                                Console.WriteLine("Числа расположены по возрастанию!");
                            }
                            else if (n1 == n2 && n2 == n3 && n3 == n4)
                            {
                                Console.WriteLine("Они равны. Их произведение = {0:F4}", n1 * n2 * n3 * n4);
                            }
                            else 
                            {
                                Console.WriteLine("Числа не находтся в возрастающим порядке. Минимальный из них = {0:F4}", Math.Min(n1, Math.Min(n2, Math.Min(n3, n4))));
                            }
                            break;
                        case 3:
                            double a1, b, c;
                            Console.WriteLine("Введите числа a b c: ");
                            String sss = Console.ReadLine();
                            a1 = Convert.ToDouble(sss.Split(' ')[0]);
                            b= Convert.ToDouble(sss.Split(' ')[1]);
                            c = Convert.ToDouble(sss.Split(' ')[2]);
                            double tmx, tmd, tmn;  // max midle min
                            tmx = Math.Max(a1, Math.Max(b, c));
                            tmn = Math.Min(a1, Math.Min(b, c));
                            tmd = (a1 + b + c) - (tmx + tmn);
                            a1 = tmx;
                            b = tmd;
                            c = tmn;
                            Console.WriteLine("a {0} \nb: {1}\nc: {2}", a1, b, c);
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3._2_23._01._2021_
{
    class Program
    {
        static void Main(string[] args)
        {
            int pNumber;
            String s;
            Console.WriteLine("ДЗ3.2 на дату 23.01.2021 \nВводите номер задание для проверки(1-3). Чтобы выйти вводите 'q'!");
            s = Console.ReadLine();
            while (true)
            {
                if (s == "q") break;
                else if (Int32.TryParse(s, out pNumber))
                {
                    switch (pNumber)
                    {
                        case 1:
                            Console.Write("Вводите размер массива: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            int mx, mn, sum;
                            int[] arr = new int[n];
                            var rand = new Random();
                            for (int i = 0; i < n; i++)
                            {
                                arr[i] = rand.Next(5000);
                            }
                            mx = arr[0];
                            mn = arr[0];
                            sum = 0;
                            Console.WriteLine("\nМассив со случаййными числами:");
                            for (int i = 0; i < n; i++)
                            {
                                Console.Write(arr[i].ToString()+" ");
                                if(arr[i]>mx) mx = arr[i];
                                if (mn > arr[i]) mn = arr[i];
                                sum += arr[i];
                            }
                            Console.WriteLine("\n\nНаибольший элемент : {0} \nНаименьший элемент: {1}\nСумма всех элементов: {2}\nСреднее арифметическое: {3:F4}\n", mx, mn, sum, (sum + 0.1) / (n + 0.1));
                            Console.WriteLine("Все нечетные элементый массива: ");
                            for (int i = 0; i < n; i++)
                            {
                                if (arr[i] % 2 == 1) Console.Write(arr[i].ToString() + " ");
                            }
                            Console.WriteLine("");

                            break;
                        case 2:
                            Console.Write("Вводите размер массива: ");
                            int n2 = Convert.ToInt32(Console.ReadLine());
                            int[] arr2 = new int[n2];
                            Console.Write("Водите {0} чисел через пробел: ", n2);
                            String ss = Console.ReadLine();
                            for (int i = 0; i < n2; i++)
                            {
                                arr2[i] = Convert.ToInt32(ss.Split(' ')[i]);                                
                            }
                            Console.WriteLine("\nВведенный массив:");
                            for (int i = 0; i < n2; i++)
                            {
                                Console.Write(arr2[i].ToString() + " ");
                            }
                            Array.Reverse(arr2, 0, n2);
                            Console.WriteLine("\nВведенный массив в обратном порядке:");
                            for (int i = 0; i < n2; i++)
                            {
                                Console.Write(arr2[i].ToString() + " ");
                            }
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.Write("Вводите размер массива N: ");
                            int n3 = Convert.ToInt32(Console.ReadLine());
                            int[] arr3 = new int[n3];
                            var rand3 = new Random();
                            Console.WriteLine("\nМассив со случаййными числами:");
                            for (int i = 0; i < n3; i++)
                            {
                                arr3[i] = rand3.Next(5000);
                                Console.Write(arr3[i].ToString() +" ");
                            }
                            Console.Write("\nВводите count: ");
                            int count = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Вводите index: ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            int[] newArr = new int[count];
                            for (int i = 0; i < count; i++)
                            {
                                if (i + index - 1 < n3)
                                    newArr[i] = arr3[i + index - 1];
                                else
                                    newArr[i] = 1;
                            }
                            Console.WriteLine("Полученный массив: \n");
                            for (int i = 0; i < count; i++)
                            {
                                Console.Write(newArr[i].ToString()+" ");
                            }
                            Console.WriteLine("");
                            break;

                    };
                    Console.WriteLine("Чтобы продолжить еще раз вводите номер задачи(1-3). Чтобы выйти вводите 'q'.");
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильный номер задачи. Вводите еще раз(1-3). Чтобы выйти вводите 'q'.");
                }
                s = Console.ReadLine();
            }
            Console.WriteLine("Приходите еще!");
            Console.ReadLine();
        }
    }
}

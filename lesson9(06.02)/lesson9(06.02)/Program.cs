using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9_06._02_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[] { "ant", "bison", "Naruto", "duck" };
            double[] d = new Double[] { 12.23, 45.675, 2323.32, 565.32, 544.23 };
            int[] n = new int[] { 1234, 434, 234, 2312, 1212, 111, 222, 33 };
            char[] c = new char[] { 'g', 'o', 'o', 'd', ' ', 'a', 'l', 'i', 'f' };
            float[] f = new float[] { 12.2f, 43.123f, 434.23f, -23.3f, -433.12f, 1.1f, 12.0f};

            ArrayHelper.Show(s);
            Console.WriteLine("result of POP to this array: "+ArrayHelper.Pop(ref s));
            ArrayHelper.Show(s);
            Console.WriteLine("");

            ArrayHelper.Show(d);
            Console.WriteLine("result of PUSH to this array: " + ArrayHelper.Push(ref d, 543.56));
            ArrayHelper.Show(d);
            Console.WriteLine("");

            ArrayHelper.Show(n);
            Console.WriteLine("result of Shift to this array: " + ArrayHelper.Shift(ref n));
            ArrayHelper.Show(n);
            Console.WriteLine("");

            ArrayHelper.Show(c);
            Console.WriteLine("result of UnShift to this array: " + ArrayHelper.UnShift(ref c, '!'));
            ArrayHelper.Show(c);
            Console.WriteLine("");


            ArrayHelper.Show(f);
            Console.WriteLine("result of slice() to this array: "); ArrayHelper.Show(ArrayHelper.Slice(f));
            Console.WriteLine("result of slice(3) to this array: "); ArrayHelper.Show(ArrayHelper.Slice(f,3));
            Console.WriteLine("result of slice(-2) to this array: "); ArrayHelper.Show(ArrayHelper.Slice(f,-2));
            Console.WriteLine("result of slice(1,5) to this array: "); ArrayHelper.Show(ArrayHelper.Slice(f,1,5));
            Console.WriteLine("result of slice(-4,5) to this array: "); ArrayHelper.Show(ArrayHelper.Slice(f,-4,5));
            ArrayHelper.Show(f);
            Console.ReadLine();

        }

        static class ArrayHelper
        {
            public static T Pop<T>(ref T[] s)
            {
                T tmp;
                if (s.Length == 1)
                {
                    tmp = s[0];
                    s = null;
                    return tmp;
                }
                else if (s.Length > 1)
                {
                    tmp = s[s.Length - 1];
                    T[] ns = new T[s.Length - 1];
                    for (int i = 0; i < s.Length-1; i++)
                    {
                        ns[i] = s[i];
                    }
                    s = ns;
                    return tmp;
                }
                return default(T);
            }
            public static int Push<T>(ref T[] s, T a)
            {
                if (s.Length == 0)
                {
                    s = new T[]{a};
                    return 1;

                }
                else if (s.Length > 1)
                {
                    T[] ns = new T[s.Length + 1];
                    for (int i = 0; i < s.Length; i++)
                    {
                        ns[i] = s[i];
                    }
                    ns[s.Length] = a;
                    s = ns;
                    return s.Length;
                }
                return 0;
            }
            public static T Shift<T>(ref T[] s)
            {
                T tmp;
                if (s.Length == 1)
                {
                    tmp = s[0];
                    s = null;
                    return tmp;
                }
                else if (s.Length > 1)
                {
                    tmp = s[0];
                    T[] ns = new T[s.Length - 1];
                    for (int i = 0; i < s.Length - 1; i++)
                    {
                        ns[i] = s[i+1];
                    }
                    s = ns;
                    return tmp;
                }
                return default(T);
            }
            public static int UnShift<T>(ref T[] s, T a)
            {
                if (s.Length == 0)
                {
                    s = new T[] { a };
                    return 1;

                }
                else if (s.Length > 1)
                {
                    T[] ns = new T[s.Length + 1];
                    ns[0] = a;
                    for (int i = 0; i < s.Length; i++)
                    {
                        ns[i+1] = s[i];
                    }
                    s = ns;
                    return s.Length;
                }
                return 0;
            }
            public static T[] Slice<T>(T[] s, int begin = 0, int end = 0) 
            {
                int n = s.Length;
                if (end == 0) end = s.Length;
                if (Math.Abs(begin) > n || Math.Abs(end) > n)
                {
                    return default(T[]);
                }
                if(begin <  0 )
                {
                    begin = n + begin;
                }
                if(end<0)
                {
                    end = n + end;
                }
                Console.WriteLine(begin + " "+end);
                if (end < begin)
                {
                    return default(T[]);
                }
                
                int dif = end - begin;
                if (dif == 0) return default(T[]);
                T[] ns = new T[dif];
                for (int i = 0; i < dif; i++)
                {
                    Console.WriteLine(i + begin);
                    ns[i] = s[i + begin];
                }
                return ns;
            }
            public static void Show<T>(T[] s)
            {
                if (s == null) return;
                for (int i = 0; i < s.Length; i++)
                {
                    Console.Write(s[i] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}

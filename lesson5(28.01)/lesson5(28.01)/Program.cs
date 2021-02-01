using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5_28._01_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "First", "Second", "Third", "Fourth", "Fifth" };
            int[] N = { 1, 56, 32, 45, 98, 4, 5 };
            Double[] d = { 1.25, 56.23, -65, 458.635 };
            decimal[] dc = { 1.23m, 6565.6m, 454.606m, 4545.6m };
            float[] fl = { 10.23f, -45.65f, 4545.01f };
            // poping
            Console.WriteLine(ArrayHelper.Pop(ref s));
            ArrayHelper.Show(s);

            Console.WriteLine(ArrayHelper.Pop(ref dc));
            ArrayHelper.Show(dc);

            //pushing
            ArrayHelper.Push(ref s, "Sixth");
            ArrayHelper.Show(s);

            ArrayHelper.Push(ref N, 555);
            ArrayHelper.Show(N);

            //Shifting
            ArrayHelper.Shift(ref s);
            ArrayHelper.Show(s);

            ArrayHelper.Shift(ref d);
            ArrayHelper.Show(d);

            //UnShhifting
            ArrayHelper.UnShift(ref s, "Zeros");
            ArrayHelper.Show(s);

            ArrayHelper.UnShift(ref fl, 1.05f);
            ArrayHelper.Show(N);



            Console.ReadLine();

        }
    }

    static class ArrayHelper
    {
        //pop
        public static string Pop(ref string[] s)
        {            
            string tmp;
            if(s.Length == 1 )
            {   
                tmp = s[0];
                s = null;
                return tmp;
            }
            else if (s.Length>1)
            {
                tmp = s[s.Length-1];
                string[] ns = new String[s.Length - 1];
                for (int i = 0; i < s.Length-1; i++)
                {
                    ns[i] = s[i];
                }
                s = ns;
                return tmp;
            }       
            return "";
        }
        public static int Pop(ref int[] s)
        {
            int tmp;
            if (s.Length == 1)
            {
                tmp = s[0];
                s = null;
                return tmp;
            }
            else if (s.Length > 1)
            {
                tmp = s[s.Length - 1];
                int[] ns = new int[s.Length - 1];
                for (int i = 0; i < s.Length - 1; i++)
                {
                    ns[i] = s[i];
                }
                s = ns;
                return tmp;
            }
            return 0;
        }
        public static double Pop(ref double[] s)
        {
            double tmp;
            if (s.Length == 1)
            {
                tmp = s[s.Length - 1];
                s = null;
                return tmp;
            }
            else if (s.Length > 1)
            {
                tmp = s[0];
                double[] ns = new double[s.Length - 1];
                for (int i = 0; i < s.Length - 1; i++)
                {
                    ns[i] = s[i];
                }
                s = ns;
                return tmp;
            }
            return 0;
        }
        public static float Pop(ref float[] s)
        {
            float tmp;
            if (s.Length == 1)
            {
                tmp = s[0];
                s = null;
                return tmp;
            }
            else if (s.Length > 1)
            {
                tmp = s[s.Length - 1];
                float[] ns = new float[s.Length - 1];
                for (int i = 0; i < s.Length - 1; i++)
                {
                    ns[i] = s[i];
                }
                s = ns;
                return tmp;
            }
            return 0;
        }
        public static decimal Pop(ref decimal[] s)
        {
            decimal tmp;
            if (s.Length == 1)
            {
                tmp = s[0];
                s = null;
                return tmp;
            }
            else if (s.Length > 1)
            {
                tmp = s[s.Length - 1];
                decimal[] ns = new decimal[s.Length - 1];
                for (int i = 0; i < s.Length - 1; i++)
                {
                    ns[i] = s[i];
                }
                s = ns;
                return tmp;
            }
            return 0;
        }

        // push
        public static int Push(ref string[] s, string el)
        {
            if(s.Length==0)
            {
                s = new string[] { el };
                return 1;
            }
            string[] tmp = new string[s.Length + 1];
            s.CopyTo(tmp, 0);
            tmp[s.Length] = el;
            s = tmp;
            return s.Length+1;
        }
        public static int Push(ref int[] s, int el)
        {
            if (s.Length == 0)
            {
                s = new int[] { el };
                return 1;
            }
            int[] tmp = new int[s.Length + 1];
            s.CopyTo(tmp, 0);
            tmp[s.Length] = el;
            s = tmp;
            return s.Length + 1;
        }
        public static int Push(ref double[] s, double el)
        {
            if (s.Length == 0)
            {
                s = new double[] { el };
                return 1;
            }
            double[] tmp = new double[s.Length + 1];
            s.CopyTo(tmp, 0);
            tmp[s.Length] = el;
            s = tmp;
            return s.Length + 1;
        }
        public static int Push(ref float[] s, float el)
        {
            if (s.Length == 0)
            {
                s = new float[] { el };
                return 1;
            }
            float[] tmp = new float[s.Length + 1];
            s.CopyTo(tmp, 0);
            tmp[s.Length] = el;
            s = tmp;
            return s.Length + 1;
        }
        public static int Push(ref decimal[] s, decimal el)
        {
            if (s.Length == 0)
            {
                s = new decimal[] { el };
                return 1;
            }
            decimal[] tmp = new decimal[s.Length + 1];
            s.CopyTo(tmp, 0);
            tmp[s.Length] = el;
            s = tmp;
            return s.Length + 1;
        }

        //Shifting 
        public static string Shift(ref string[] s)
        {
            string tmp;
            if (s.Length == 1)
            {
                tmp = s[0];
                s = null;
                return tmp;
            }
            else if (s.Length > 1)
            {
                tmp = s[0];
                string[] ns = new String[s.Length - 1];
                for (int i = 0; i < s.Length - 1; i++)
                {
                    ns[i] = s[i+1];
                }
                s = ns;
                return tmp;
            }
            return "";
        }
        public static int Shift(ref int[] s)
        {
            int tmp;
            if (s.Length == 1)
            {
                tmp = s[0];
                s = null;
                return tmp;
            }
            else if (s.Length > 1)
            {
                tmp = s[0];
                int[] ns = new int[s.Length - 1];
                for (int i = 0; i < s.Length - 1; i++)
                {
                    ns[i] = s[i + 1];
                }
                s = ns;
                return tmp;
            }
            return 0;
        }
        public static double Shift(ref double[] s)
        {
            double tmp;
            if (s.Length == 1)
            {
                tmp = s[0];
                s = null;
                return tmp;
            }
            else if (s.Length > 1)
            {
                tmp = s[0];
                double[] ns = new double[s.Length - 1];
                for (int i = 0; i < s.Length - 1; i++)
                {
                    ns[i] = s[i + 1];
                }
                s = ns;
                return tmp;
            }
            return 0;
        }
        public static float Shift(ref float[] s)
        {
            float tmp;
            if (s.Length == 1)
            {
                tmp = s[0];
                s = null;
                return tmp;
            }
            else if (s.Length > 1)
            {
                tmp = s[0];
                float[] ns = new float[s.Length - 1];
                for (int i = 0; i < s.Length - 1; i++)
                {
                    ns[i] = s[i + 1];
                }
                s = ns;
                return tmp;
            }
            return 0;
        }
        public static decimal Shift(ref decimal[] s)
        {
            decimal tmp;
            if (s.Length == 1)
            {
                tmp = s[0];
                s = null;
                return tmp;
            }
            else if (s.Length > 1)
            {
                tmp = s[0];
                decimal[] ns = new decimal[s.Length - 1];
                for (int i = 0; i < s.Length - 1; i++)
                {
                    ns[i] = s[i + 1];
                }
                s = ns;
                return tmp;
            }
            return 0;
        }

        //Unshifting
        public static int UnShift(ref string[] s, string el)
        {
            if (s.Length == 0)
            {
                s = new string[] { el };
                return 1;
            }
            string[] tmp = new string[s.Length + 1];
            s.CopyTo(tmp, 1);
            tmp[0] = el;
            s = tmp;
            return s.Length + 1;
        }
        public static int UnShift(ref int[] s, int el)
        {
            if (s.Length == 0)
            {
                s = new int[] { el };
                return 1;
            }
            int[] tmp = new int[s.Length + 1];
            s.CopyTo(tmp, 1);
            tmp[0] = el;
            s = tmp;
            return s.Length + 1;
        }
        public static int UnShift(ref double[] s, double el)
        {
            if (s.Length == 0)
            {
                s = new double[] { el };
                return 1;
            }
            double[] tmp = new double[s.Length + 1];
            s.CopyTo(tmp, 1);
            tmp[0] = el;
            s = tmp;
            return s.Length + 1;
        }
        public static int UnShift(ref float[] s, float el)
        {
            if (s.Length == 0)
            {
                s = new float[] { el };
                return 1;
            }
            float[] tmp = new float[s.Length + 1];
            s.CopyTo(tmp, 1);
            tmp[0] = el;
            s = tmp;
            return s.Length + 1;
        }
        public static int UnShift(ref decimal[] s, decimal el)
        {
            if (s.Length == 0)
            {
                s = new decimal[] { el };
                return 1;
            }
            decimal[] tmp = new decimal[s.Length + 1];
            s.CopyTo(tmp, 1);
            tmp[0] = el;
            s = tmp;
            return s.Length + 1;
        }


        public static void Show<T>(T[] arr)
        {
            if (arr.Length == 0) return;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString()+" ");
            }
            Console.WriteLine("");
        }
    }
}


// Можно было бы эту задачу решать намного легче используя шаблоны как процедура ArrayHelper.Show(N) в данном контексте. то есть для всех перегрузок создать одну шаблонную функцию и задача была бы легче

/*     // Пример решение для функции РОР с помошью шаблонов.
          public static T Pop<T>(ref T[] s)
        {            
            T tmp ;
            if(s.Length == 1 )
            {   
                tmp = s[0];
                s = null;
                return tmp;
            }
            else if (s.Length>1)
            {
                tmp = s[s.Length-1];
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



*/


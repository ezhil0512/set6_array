using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_6array
{
    class Program
    {
        static void Main(string[] args)
        {
           //int[,] a = new int[,]{ { 3, 5, 7 },{ 4, 5, 6 }};
            //evennumber(a);
           // max(a);
            //prime();
           //allsprt(a);
          // allprime(a);
           //ac(a);
            //q10();
          //  int[][] a = new int[3][];
         Q40();
            //int[] a=new int[]{3,4,5,6,7,8,9};
            //showarray(a);
           // oddnumber(a);
            //int[] a = new int[] { 16, 25, 49, 74, 64, 82, 81, 100 };
          // GetSqrt(a);
          

        }


        public static int m(String message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        public static bool pos(int a)
        {
            return a >= 0;
        }

        public static void d1()
        {
            int[] a = new int[5];
            a[0] = 10;
            a[1] = 30;
            a[2] = 60;
            a[3] = 80;
            a[4] = 100;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i] + sum);
                sum = a[i] + sum;
            }
        }

        public static void d2()
        {
            int[] a = new int[] { 2, 3, 4, 5, 9 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public static void q11()
        {
            int n = m("enter your range");
            int k = m("enter your initialized");
            int[] s1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                s1[i] = k;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(s1[i]);
            }
        }

        public static void q1()
        {
            int n = m("enter the size of array");
            int k = m("enter the element in array");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = k;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        //public static void q2()  //d
        //{
        //    int n=m("enter the size of array");
        //    int[] a = new int[n];
        //    for (int i = 0; i <a.Length; i++)
        //    {
        //        a[i] = K
        //    }
        //}

        public static void q3()
        {
            int n = m("enter the size of array");
            int[] a = new int[n];
            int i = m("enter the starting number");
            int j = m("enter the ending number");
            for (int k = 0; k < n; k++)
            {
                Random r = new Random();
                Console.WriteLine(r.Next(i, j));
            }
        }

        public static void q4()
        {
            int x = m("enter your starting point of array range");
            int y = m("enter your ending point of array range");
            int i = m("enter the starting element");
            int j = m("enter the ending element");
            Random r = new Random();
            int r1 = r.Next(x, y);
            int[] a = new int[r1];
            for (int k = 0; k < r1; k++)
            {
                Random rr = new Random();
                Console.WriteLine(rr.Next(i, j));
            }
        }

        //public static void q5()
        //{
        //    int[] a =new int[n] ;
        //    {
        //        for (int i = 0; i < a.Length; i++)
        //        {
        //            Console.WriteLine(a[i]);
        //        }
        //    }
        //}
        public static int copy()
        {
           return int.Parse(Console.ReadLine());
        }

        //public static void q66()
        //{
        //    int a = copy();
        //    int b = copy();
        //    int c = copy();
        //    int[] s1 = new int[] { a, b, c };
        //    for (int i = 0; i < s1.Length; i++)
        //    {
        //        Console.WriteLine(s1[i]);
        //    }
        //}

        public static void q6()
        {
            int[] a = new int[] { 2, 3, 4, 5, 6 };
            for (int i = a.Length - 1; i>=0; i--)
            {
                Console.WriteLine(a[i]);  
            }
        }
        public static bool even(int n)
        {
            return n % 2 == 0;
        }

        public static void q7()
        {
            int[] a = new int[] { 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i < a.Length; i++)
            {
                if (even(i) == true)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
          
        public static void q7a()
        {
            int[] a = new int[] { 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i < a.Length; i++)
            {
                if (even(i) != true)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }

        public static void q8()
        {
            int k = m("enter the number of element");
            int[] a = new int[] { 8, 7, 6, 5, 4, 3 };
            {
                for (int i = 0; i <= k; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }


        public static void q9()
        {
            int k = m("enter the starting point of aray");
            int[] a = new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };
            {
                for (int i = k; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }


        public static void q10()
        {
            int k = m("enter the starting point in array");
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            {
                for (int i = k; i < a.Length; i=i+2)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }

        public static void que()
        {
            int[] a=new int[]{1,2,3,4,5};
            for (int i = 0; i < a.Length; i++)
            {
                if (i < a.Length - 1)
                {
                    Console.WriteLine(i + ":" + a[i] + ",");
                }
                else
                {
                    Console.WriteLine(i + ":" + a[i]);
                }
            }
        }


        public static void q13()
        {
            int[] a = new int[] { 8, 7, 6, 5, 4 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[0] - a[i]);
            }
        }

        public static void q14()
        {
            int[] a = new int[] { 2, 3, 4, 5, 6 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine(sum);
        }

        public static int q15()
        {
            int[] a = new int[] { 4, 7, 6, 9, 3, 9 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (even(i) == true)
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine(sum);
            return sum;
        }


        public static void q16()
        {
            int[] a = new int[] { 4, 7, 6, 9, 15, 9 };
            int osum = 0;
            int esum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (even(i) != true)
                {
                    osum = osum + a[i];
                }
                else
                {
                    esum = esum + a[i];
                }
            }
                if (osum == esum)
                {
                    Console.WriteLine("equal");
                }
                else
                {
                    Console.WriteLine("not equal");
                }
        }


        public static float q17(int[] a)
        {
           // int[] a = new int[] { 3, 4, 5, 6, 7 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            //Console.WriteLine((float)sum / a.Length);
            return ((float)sum / a.Length);
        }

        public static int q18(int[] a)
        {
            int cout = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    cout++;
                }
            }
            return cout;
        }


        public static int GetPositiveCount(int[] a)
        {
            int pos = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                {
                    pos++;
                }
                
            }
            return pos;
        }
        
        public static void q19(int[] a)
        {
            int pos = GetPositiveCount(a);
            int neg = a.Length - pos;
            if (pos == neg)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }


        public static void q20()
        {
            int[] a = new int[] { 3, 0, 9, 0, 5, 8, 9,0 };
            Console.WriteLine(non_zero_element_mean(a));
           
        }

        public static float non_zero_element_mean(int[] a)
        {
            int sum = 0;
            int l = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    sum = sum + a[i];
                    l++;
                }
            }
            return ((float)sum / l);
        }


        public static void q21(int[] a)
        {
            //int[] a = new int[] { 3, 4, 5, 6, 7 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(q17(a) - a[i]);
            }
        }

        public static void evennumber(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (even(a[i]) == true)
                {
                    Console.WriteLine(a[i]);
                }

            }
        }
        public static int max(int[] a)
        {
              int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);
            return max;
        }
          


        //public static void square(int[] a)
        //{
        //    //int[] a = new int[] { 99, 88, 81, 64, 36, 16, 25, 49,100};
        //    int max = 0;
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (max < a[i])
        //        {
        //            max = a[i];
        //        }
        //    }
        //    int l=(int)Math.Sqrt(max);
        //    for (int j = 0; j <= l; j++)
        //    {
        //        int c = j * j;
        //        for (int i = 0; i < a.Length; i++)
        //        {
        //            if (c == a[i])
        //            {
        //                Console.WriteLine(a[i]);
        //            }
        //        }
        //    }
        //}
        

        //public static void prime()
        //{
        //    int[] a = new int[] { 2, 3, 4, 5, 6, 7, 8, 9 };
        //    int l = max(a);
        //    int zero = 0;
        //    for (int j = 2; j <= l; j++)
        //    {
        //        for (int i = 0; ; )
        //        {
        //            if (a[i] % j == 0)
        //            {
        //                Console.WriteLine(a[i]);
        //                zero++;
        //            }
        //            if (i == l)
        //            {
        //                break;
        //            }
        //        }
        //    }
        //}

        //public static void primed()
        //{
        //    int[] a = new int[] { 2, 3, 4, 5, 6, 7, 8, 9 };
        //    int l = max(a);
        //    for (int i = 0; ;i++)
        //    {
        //        for (int j = 2; j <= l; j++)
        //        {
        //            if (a[i] % j == 0)
        //            {
        //                Console.WriteLine(a[i]);
        //            }
        //        }
        //        if (i == l)
        //        {
        //            break;
        //        }
        //    }
        //}


        //public static bool primed()
        //{
        //    int[] a = new int[] { 6, 8, 5, 7, 11, 15, 17 };
        //    bool isprime = true;
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        for (int j = 2; j < a[i]; j++)
        //        {
        //            if (a[i] % j == 0)
        //            {
        //                isprime = false;
        //                break;
        //            }
        //        }
        //    }
        //    return isprime;
        //}



        public static bool primed(int[] a)
        {
            bool isprime = true;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 2; j < a[i]; j++)
                {
                    if (a[i] % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
            }
            return isprime;
        }


        //public static int[] allprime(int[] a)
        //{
        //    int[] b = new int[a.Length];
        //    primed(a);
        //    int ar=
        //    Console.WriteLine();
        //    return b;
        //}



//two dimension
        public static void d21()
        {
            int[,] a = new int[2, 2];
            a[0, 0] = 1;
            a[0, 1] = 2;
            a[1, 0] = 3;
            a[1, 1] = 4;
            Console.WriteLine(a[0,0]);
        }

        public static void d22(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void d23()
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 3, 4, 5, 6 };
            a[1] = new int[] { 3, 4, 5 };
            a[2] = new int[] { 2, 3, 4, 5, 6 };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j]);
                }
                Console.WriteLine();
            }
        }


        public static void d24(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i, j]);
                }
            }
        }




        public static int GetOddCount(int[] a)
        {
            int oddcount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    oddcount++;
                }
            }
            return oddcount;

        }

        public static int[] oddnumber(int[] a)
        {
            int oddcount = GetOddCount(a);
            int[] oddarray = new int[oddcount];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                     //Console.WriteLine(a[i]);
                     oddarray[index] = a[i];
                     index++;
                }
            }
            return oddarray;

        }

        public static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        public static void Q40()
        {
            int[] a = new int[] { 2, 6, 8, 1, 7, 5, 9, 22, 26, 50 };

            int[] oddarray = oddnumber(a);

            PrintArray(oddarray);
        }



        public static void GetSqrt(int[] a)
        {
            int[] b = square(a);
            PrintArray(b);
        }


        public static int Geteven(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int[] arrayeven(int[] a)
        {
            int[] b = new int[Geteven(a)];
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    b[j] = a[i];
                    j++;
                }
            }
            return b;
        }

        public static void q41()
        {
            int[] a = new int[] { 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] c = arrayeven(a);
            PrintArray(c);
        }


        public static int[] allnum(int[] a)
        {
            int[] b = new int[a.Length];
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                b[j] = a[i];
                j++;
            }
            return b;
        }

        public static void pntarray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        public static void showarray(int[] a)
        {
            pntarray(allnum(a));
        }




        public static int[] square(int[] a)
        {
            int[] b = new int[a.Length];
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            int l = (int)Math.Sqrt(max);
            for (int j = 0; j <= l; j++)
            {
                int c = j * j;
                for (int i = 0; i < a.Length; i++)
                {
                    if (c == a[i])
                    {
                        Console.WriteLine(a[i]);
                    }
                }
            }
            return b;
        }

        public static int maxi(int[] a)
        {
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }

        public static int countsq(int[] a)
        {
            int count=0;
            int l = (int)Math.Sqrt(maxi(a));
            for (int j = 0; j <= l; j++)
            {
                int c = j * j;
                for (int i = 0; i < a.Length; i++)
                {
                    if (c == a[i])
                    {
                        Console.WriteLine(a[i]);
                        count++;
                    }
                }
            }
            return count;
        }


        public static int[] pfsq()
        {
            int[] a=new int[]{4,9,16,17,25,26,36,88,81};
            int [] b=new int[countsq(a)];
            int d=0;
            for (int j = 0; j <= l; j++)
            {
                int c = j * j;
                for (int i = 0; i < a.Length; i++)
                {
                    if (c == a[i])
                    {
                        
                    }
                }
            }
        }



        public static int[] pfssq()
        {
            int[] a = new int[] { 4, 9, 16, 17, 25, 26, 36, 88, 81 };
            int[] b = new int[countsq(a)];
            int d = 0;
            for (int j = 0; j <= l; j++)
            {
                int c = j * j;
                for (int i = 0; i < a.Length; i++)
                {
                    if (c == a[i])
                    {

                    }
                }
            }
        }

        public static int[] pfsssq()
        {
            int[] a = new int[] { 4, 9, 16, 17, 25, 26, 36, 88, 81 };
            int[] b = new int[countsq(a)];
            int d = 0;
            for (int j = 0; j <= l; j++)
            {
                int c = j * j;
                for (int i = 0; i < a.Length; i++)
                {
                    if (c == a[i])
                    {

                    }
                }
            }
        }



    }
}

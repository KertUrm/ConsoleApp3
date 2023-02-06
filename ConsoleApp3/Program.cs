using System;
using System.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] b = { 2, 5, 2, 6, 1, 7, 8, 1, 9, 6, 0, 7, 34, 61, 67, 12, 97, 34, 45 };
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IntToBinary(a));
            Console.WriteLine(IsEven(a));
            Console.WriteLine(Max(b));
            Console.WriteLine(Min(b));
            Console.WriteLine(Sum(b));
            Console.WriteLine(Average(b));
            Console.WriteLine(Median(b));
        }
        public static string IntToBinary(int n)
        {
            string n2="";
            while(0<n)
            {
                n2 += n % 2;
                n /= 2;
            }
            char[] charArray = n2.ToCharArray();
            Array.Reverse(charArray);
            n2 = new string(charArray);
            return n2;
        }
        public static bool IsEven(int n)
        {
            return (n % 2 == 0);
        }
        public static int Max (int[] n)
        {
            int n2=0;
            foreach (int i in n)
            {
                if (i > n2)
                {
                    n2 = i;
                }
            }
            return n2;
        }
        public static int Min(int[] n)
        {
            int n2 = 0;
            foreach (int i in n)
            {
                if (i < n2)
                {
                    n2 = i;
                }
            }
            return n2;
        }
        public static int Sum(int[] n)
        {
            int n2=0;
            foreach (int i in n)
            {
                n2 += i;
            }
            return n2;
        }
        public static double Average(int[] n)
        {
            int n2 = 0;
            foreach (int i in n)
            {
                n2 += i;
            }
            return n2 /= n.Length;
        }
        public static double Median(int[] n)
        {
            Array.Sort(n);
            if (n.Length % 2 == 0)
            {
            return (n[n.Length/2]+ n[n.Length/2-1])/2;
            }
            return n[n.Length / 2];
        }
    }
}

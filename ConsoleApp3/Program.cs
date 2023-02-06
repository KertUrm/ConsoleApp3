using System;
using System.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IntToBinary(a));
        }
        public static string IntToBinary(int n)
        {
            string n2="";
            while(0<n)
            {
                n2 += n % 2;
                n/= 3;
            }
            char[] charArray = n2.ToCharArray();
            Array.Reverse(charArray);
            n2 = new string(charArray);
            return n2;
        }
    }
}

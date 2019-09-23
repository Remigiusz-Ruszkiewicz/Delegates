using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    
    class Program
    {
        public delegate void Result(int x,int y);
        static void Sum(int x, int y)
        {
            Console.WriteLine((x + y).ToString()); 
        }
        static void Multiply(int x, int y)
        {
            Console.WriteLine((x * y).ToString()); 
        }
        static bool IsEqual(string a, string b)
        {
            return a == b;
        }
        static bool IsNotEqual(string a, string b)
        {
            return a != b;
        }
        static void Main(string[] args)
        {
            var r = new Result(Sum);
            r += Multiply;
            r(2, 3);
            r -= Sum;
            r(12, 3);
            Action<int, int> action = new Action<int, int>(Sum);
            action += Multiply;
            action(4, 6);
            Func<string, string, bool> func = new Func<string, string, bool>(IsEqual);
            Console.WriteLine(func("a","a"));
            func += IsNotEqual;
            Console.WriteLine(func("a", "A"));
            Console.Read();
        }
    }
}

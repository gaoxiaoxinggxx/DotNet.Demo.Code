using System;
using System.Threading;
using System.Threading.Tasks;

namespace _01.Generic泛型
{
    public class Program
    {
        /// <summary>
        /// 1.泛型的引入，声明和使用
        /// 2.泛型的原理，泛型的缓存
        /// 3.泛型的好处和应用
        /// </summary>
        /// <param name="args"></param>
       public static void Main(string[] args)
        {
            // demo 1
            //string value1 = CustomCache.Get<int>();
            //Thread.Sleep(3000);
            //string value2 = CustomCache.Get<int>();

            // demo 2
            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            // 在交换之前显示值
            Console.WriteLine("Int values before calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values before calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);

            // 调用 swap
            GenericMethod.Swap<int>(ref a, ref b);
            GenericMethod.Swap<char>(ref c, ref d);

            // 在交换之后显示值
            Console.WriteLine("Int values after calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values after calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);
            Console.WriteLine("Hello World!");
        }
    }
}

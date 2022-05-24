using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Generic泛型
{
    public class GenericMethod
    {
        public static void Show<T>(T tParameter) where T : People
        {
            Type type = tParameter.GetType();
            int id = tParameter.Id;
            string name = tParameter.Name;

            tParameter.Walk();

            Console.WriteLine($"This is type{0}", tParameter.GetType());
        }

        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Walk()
        {
            Console.WriteLine("1111111111111");
        }
       
    }
}

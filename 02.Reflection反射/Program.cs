using System;
using System.Reflection;

namespace _02.Reflection反射
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Person person = new Person();
            Type t = person.GetType();

            // 通过程序获取类型
            Type t2 = Type.GetType("_02.Reflection反射.Person");
            Console.WriteLine("t2:" + t2);

            //MethodInfo m = t.GetMethod("Show");
            //m.Invoke(t,null);

            // 第一种创建方式：创建一个无参的类
            object personObj = Activator.CreateInstance(t2);
            ((Person)personObj).Show();

            // 第二种创建方式：创建一个有参的类
            //object[] obj = new object[] { "高小星","25" };
            //object personObj = Activator.CreateInstance(t,obj);
            //((Person)personObj).Show();




            Console.WriteLine("Hello World!");
        }
    }

    public class Person
    {
        public string _name;

        public string Name { get; set; }

        public int Age { get; set; }

        public Person()
        { }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Show()
        {
            Console.WriteLine("你好" + this.Name);
        }
    }

}

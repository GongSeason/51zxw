using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义泛型类创建
{

    public class TGeneric<T>
    {
        public T Field;

    }

    class commonlyClass
    {
        public T G<T>(T t)
        {
            return t;
        }
    }

    class TGenericTwo<T>
    {
        public T M(T t) //泛型方法
        {
            return t;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TGeneric<string> g = new TGeneric<string>();
            g.Field = "Hello World";
            Console.WriteLine(g.Field);
            Console.ReadKey();
        }
    }
}

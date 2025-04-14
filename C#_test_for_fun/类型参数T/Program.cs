using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类型参数T
{
    // 定义泛型类
    public class TGenericDemo<T>
    {
        void Exp(T input)
        {

        }
    }
    internal class Program
    {
        private class customClass
        {

        }
        static void Main(string[] args)
        {
            // 创建泛型类的实例
            TGenericDemo<char> gd1 = new TGenericDemo<char>();
            Console.WriteLine("实例化类型为char的TGenericDemo的gd1成功！");

            TGenericDemo<int> gd2 = new TGenericDemo<int>();
            Console.WriteLine("实例化类型为int的TGenericDeom的gd2成功");

            TGenericDemo<customClass> gd3 = new TGenericDemo<customClass>();
            Console.WriteLine("实例化类型为customClass的TGenericDemo的gd3成功");

            Console.ReadKey();
        }
    }
}

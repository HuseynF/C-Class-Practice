using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone Apple = new Phone("gold","iphonexs","USA");
            Apple.SetImei(123456789123456);
            Console.WriteLine(Apple.GetImei());
            Apple.Call(994502059999);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public delegate float Add(int x, int y);


namespace Delegates
{
    class Program
    {
        private static float sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //
            Add obj = new Add(sum);
            Console.WriteLine(obj.Invoke(4,7));
            Console.Read();
        }
    }
}

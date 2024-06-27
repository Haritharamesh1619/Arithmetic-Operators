using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 20;
            int B = 5;
            int C;
            C=A+B;
            Console.WriteLine("Addition value is :{0}",C);
            C = A - B;
            Console.WriteLine("subtraction value is :{0}", C);
            C = A * B;
            Console.WriteLine("Multiplication value is :{0}", C);
            C = A / B;
            Console.WriteLine("Division value is :{0}", C);
            C = A % B;
            Console.WriteLine("Division value is :{0}", C);
            Console.ReadLine();


        }
    }
}

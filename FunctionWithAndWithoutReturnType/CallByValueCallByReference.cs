using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionWithAndWithoutReturnType
{
    internal class callByValueCallByReference
    {
        public void CallByValue(int num1,int num2)
        {
            num1 = 100;
            num2 = 200;
            Console.WriteLine($"Number1={num1},Number2={num2}");
        }
        public void CallByReference(ref int num1, ref int num2)
        {
            num1 = 100;
            num2 = 200;
            Console.WriteLine($"Number1={num1},Number2={num2}");
        }
    }
}

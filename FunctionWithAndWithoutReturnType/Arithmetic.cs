using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionWithAndWithoutReturnType
{
    internal class Arithmetic
    {
        public int A { get; set; }
        public int B { get; set; }

        //parameters or arguments
        public void add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine($"addition of{num1}and {num2} is = {result}");
        }
        //public void sub(int num1,int num2)
        //{
        //    int result = num1 - num2;
        //    Console.WriteLine($"Substraction of {num1} and {num2} is={result}");
        //}
        //public void mul(int num1, int num2)
        //{
        //    int result = num1 * num2;
        //    Console.WriteLine($"Multiplication of {num1} and {num2} is ={result}");
        //}
        //public void div(int num1, int num2) 
        //{
        //     int result = num1 / num2;
        //    Console.WriteLine($"Division of {num1} AND {num2} is = {result}");
        //}

        //Complex argument or parameters
        public void add(Arithmetic arth)
        {
            int result = arth.A + arth.B;
            Console.WriteLine($"Assition of{arth.A} Ans {arth.B} IS = {result}");
        }

        //public void sub(Arithmetic arth)
        //{
        //    int result=arth.A- arth.B;
        //    Console.WriteLine($"Substraction of {arth.A} and {arth.B} is = {result}");
        //}

        //public void mul(Arithmetic arth)
        //{
        //    int result = arth.A * arth.B;
        //    Console.WriteLine($"Multiplication of {arth.A} and {arth.B} is= {result}");
        //}

        //public void div(Arithmetic arth)
        //{
        //    int result = arth.A / arth.B;
        //    Console.WriteLine($"Division of {arth.A} And {arth.B} is = {result}");
        //}

        //output parameter
        public void Add(int num1,int num2,out int result)
        {
            result = num1 + num2;
        }
       

    }   

}

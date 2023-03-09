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
       

        //Complex argument or parameters
        public void add(Arithmetic arth)
        {
            int result = arth.A + arth.B;
            Console.WriteLine($"Assition of{arth.A} Ans {arth.B} IS = {result}");
        }

        

        //FRORMAL PARAMETERS

       
        public void Add(int num1,int num2,out int result) //output parameter
        {
            result = num1 + num2;
        }

        
        public void sub(int num1, int num2, ref int result1)//input output parameters
        {
            result1 =result1 +  num1 - num2;
        }


        public int Mod(int num1,int num2)
        {
            int result = num1 % num2;
            return result;
        }

        public int ArithmeticOperation(int a,int b,
                                                  out int substractionalresult,
                                                   out int multiplicationalresult,
                                                   out int divisionalresult,
                                                   out int modresult)
        {
            int additionresult = a + b;
             substractionalresult = a - b;
             multiplicationalresult = a * b;
             divisionalresult = a / b;
             modresult = a % b;


            return additionresult;
        }

    }

}

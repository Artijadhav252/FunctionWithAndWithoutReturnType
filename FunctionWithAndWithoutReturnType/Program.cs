using FunctionWithAndWithoutReturnType;

public class  Program
{
    public static void Main()
    {
        //Arithmetic arithmetic = new Arithmetic();
        //arithmetic.add(10, 20);




        Arithmetic arithmetic1 = new Arithmetic();
        arithmetic1.A = 40;
        arithmetic1.B = 20;

        Arithmetic arithmetic = new Arithmetic();
        arithmetic.add(10, 20);
        int result;

        //Actual parameters
        arithmetic.Add(10, 20,out   result);
        Console.WriteLine($"Multiplication of 10 and 20 is ={result}");

        int result1 = 10;
        arithmetic.sub(30,20 ,ref  result1);
        Console.WriteLine($"result={result1}");



        int moderesult=arithmetic.Mod(10 ,2);


        int additionresult = arithmetic.ArithmeticOperation(20, 19, out int subsCtractionalresult,
                                                         out int multiplicationalresult,
                                                         out int divisionalresult,
                                                         out int modresult);

        
       
        Console.WriteLine($"Addition={additionresult},Substraction ={subsCtractionalresult}"
            +$"multiplicationalresult ={multiplicationalresult}, divisionalresult ={divisionalresult},Mod ={modresult}");


        int num1 = 10;
        int num2 = 20;

        //Call by value
        callByValueCallByReference CallByValueCallByReference = new callByValueCallByReference();

        Console.WriteLine("Call by value Before calling the function");
        Console.WriteLine($"Number1={num1}, Number2={num2}");



        CallByValueCallByReference.CallByValue(num1, num2);

        Console.WriteLine("Call by value After calling the function");
        Console.WriteLine($"Number1={num1}, Number2={num2}");

        //call by reference

        Console.WriteLine("Call by reference Before calling the function");
        Console.WriteLine($"Number1={num1}, Number2={num2}");



        CallByValueCallByReference.CallByReference(ref num1,ref num2);

        Console.WriteLine("Call by reference After calling the function");
        Console.WriteLine($"Number1={num1}, Number2={num2}");




        //Doctor doctor1 = new Doctor();
        //Console.WriteLine("please enter doctor1 object");
        //doctor1.GetData();
        //doctor1.PutData();

        //Doctor doctor2 = new Doctor();
        //Console.WriteLine("please enter doctor2 object");
        //doctor2.GetData();
        //doctor2.PutData();

        //Doctor.typecasting();
    }

}
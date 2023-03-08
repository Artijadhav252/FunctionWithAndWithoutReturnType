using FunctionWithAndWithoutReturnType;

public class  Program
{
    public static void Main()
    {
        Arithmetic arithmetic = new Arithmetic();
        arithmetic.add(10, 20);

        //Arithmetic arithmetic1 = new Arithmetic();  
        //arithmetic1.sub(30, 20);

        //Arithmetic arithmetic2 = new Arithmetic();
        //arithmetic2.mul(3, 2);


        //Arithmetic arithmetic3 = new Arithmetic();
        //arithmetic3.div(20, 2);


        //Arithmetic arithmetic1 = new Arithmetic();
        //arithmetic1.A = 40;
        //arithmetic1.B = 20;

        //Arithmetic arithmetic2 =  new Arithmetic();
        //arithmetic2.add(arithmetic1);

        //Arithmetic arithmetic3=new Arithmetic();    
        //arithmetic3.sub(arithmetic1);

        //Arithmetic arithmetic4 = new Arithmetic();
        //arithmetic4.mul(arithmetic1);

        //Arithmetic arithmetic5= new Arithmetic();
        //arithmetic5.div(arithmetic1);

        arithmetic.add(10, 20);
        int result;
        arithmetic.Add(10, 20,out result);
        Console.WriteLine($"Multiplication of 10 and 20 is ={result}");


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
using FunctionWithAndWithoutReturnType;

public class  program
{
    public static void Main()
    {
        Doctor doctor1 = new Doctor();
        Console.WriteLine("please enter doctor1 object");
        doctor1.GetData();
        doctor1.PutData();

        Doctor doctor2 = new Doctor();
        Console.WriteLine("please enter doctor2 object");
        doctor2.GetData();
        doctor2.PutData();

        Doctor.typecasting();
    }

}
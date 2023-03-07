using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionWithAndWithoutReturnType
{
    internal class Doctor
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int GrossIncome { get; set; }
        public int IncomeTax { get; set; }
        public int NetIncome { get; set; }

        
        //non value returning  function 
        public void GetData()
        {
            Console.WriteLine("Enter any value for Id");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value fro Name");
            Name = Console.ReadLine();

            Console.WriteLine("Please enter the value for GrossIncome");
            GrossIncome = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the value for IncomeTax");
            IncomeTax = Convert.ToInt32(Console.ReadLine());

            NetIncome = CalculateNetIncome();


        }

        //non value function without return type
        public void PutData()
        {
            Console.WriteLine("Id="+Id);
            Console.WriteLine("Name="+Name);
            Console.WriteLine("GrossIncome="+GrossIncome);
            Console.WriteLine("IncomeTax"+IncomeTax);
            Console.WriteLine("NetIncome="+NetIncome);
        }

        //value returning method
        public int CalculateNetIncome()
        {
            //int result = GrossIncome - IncomeTax;
            //return result;

            NetIncome = GrossIncome - IncomeTax;
            return NetIncome;
        }
        

        // type casting demo

        public string strId { get; set; }
        public char charId  { get;set; }

        public static void typecasting()
        {
            Doctor doctor = new Doctor();

            doctor.strId = "20";
            doctor.Id = Convert.ToInt32(Console.ReadLine());//explicit  type casting

            doctor.charId = 'b';
            doctor.Id = doctor.charId;//Implicit Type casting
            
        }

    }
}

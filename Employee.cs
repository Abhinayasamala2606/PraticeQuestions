//using System.Security.Cryptography;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
namespace ConsoleApp3
{

    public abstract class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; protected set; }

        public bool ValidateEmployeeId()
        {
            int[]id= new int[3];
            if(Id.Length==5 && Id == "EM" + id)
            {
                return true;
            }
            return false;
        }

        public abstract Employee SalaryCalculation();
    }

    public class Permanent : Employee
    {
        public double BasicPay { get; set; }

        public override Employee SalaryCalculation()
        {
            double da = BasicPay * 0.50; 
            double hra = BasicPay * 0.30; 
            Salary = BasicPay + da + hra;
            return this;
        }
    }

    public class Temporary : Employee
    {
        public int HrsWorked { get; set; }
        public int HrlyWages { get; set; }

        public override Employee SalaryCalculation()
        {
            Salary = HrsWorked * HrlyWages;
            return this;
        }
    }

    public class Employee
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose the employee type");
            Console.WriteLine("1. Permanent");
            Console.WriteLine("2. Temporary");

            int choice = int.Parse(Console.ReadLine());
            Employee employee = null;

            switch (choice)
            {
                case 1:
                    employee = new Permanent();
                    Console.WriteLine("Enter the employee id");
                    break;
                case 2:
                    employee = new Temporary();
                    Console.WriteLine("Enter the employee id");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            employee.Id = Console.ReadLine();
            if (!employee.ValidateEmployeeId())
            {
                Console.WriteLine("Invalid id");
                return;
            }

            Console.WriteLine("Enter the name");
            employee.Name = Console.ReadLine();

            if (employee is Permanent permanentEmployee)
            {
                Console.WriteLine("Enter basic pay");
                permanentEmployee.BasicPay = double.Parse(Console.ReadLine());
                employee.SalaryCalculation();
            }
            else if (employee is Temporary temporaryEmployee)
            {
                Console.WriteLine("Enter hours worked");
                temporaryEmployee.HrsWorked = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter hourly wages");
                temporaryEmployee.HrlyWages = int.Parse(Console.ReadLine());
                employee.SalaryCalculation();
            }

            Console.WriteLine($"Employee id : {employee.Id}, Name : {employee.Name}, Salary : {employee.Salary}");
        }
    }



}


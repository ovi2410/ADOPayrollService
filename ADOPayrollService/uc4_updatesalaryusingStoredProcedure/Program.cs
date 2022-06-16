// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace ADO_Employee_Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Payroll Services using ADO!");
            //Create oobject for Employee Repository
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.GetSqlData();

        }
    }
}

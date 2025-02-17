// Author: [Alvaro Pulido]
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#


namespace COMP003A.EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string employeeID;
            string firstName;
            string lastName;
            string middleName;
            double salary;

            Console.Write("Enter Employee ID: ");
            employeeID = Console.ReadLine();

            Console.Write("Enter First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter Middle Name (Press enter to skip): ");
            middleName = Console.ReadLine();
           

            Console.Write("Enter Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Enter Your Salary: ");
            salary = double.Parse(Console.ReadLine());
          

            Employee employee = new Employee (employeeID,firstName,middleName,lastName,salary);


            employee.DisplayEmployeeInfo();


            HRDepartment hrDepartment = new HRDepartment();
            hrDepartment.GetDepartmentDetails();
            
            ITDepartment iTDepartment = new ITDepartment();
            iTDepartment.GetDepartmentDetails();

        }





    }
}

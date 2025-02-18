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
            try
            {
                firstName = Console.ReadLine();
                if (string.IsNullOrEmpty(firstName))

                {
                    throw new ArgumentException("First name cannot be empty.");
                }
            }
            catch (Exception ex)
            {


                Console.WriteLine("First name cannot be empty");
                return;
            }

            Console.Write("Enter Middle Name (Press enter to skip): ");
            middleName = Console.ReadLine();


            Console.Write("Enter Last Name: ");
            try {
            lastName = Console.ReadLine();
            if (string.IsNullOrEmpty(lastName))

            {
                throw new ArgumentException("Last name cannot be empty.");
            }
        }
            catch (Exception ex)
            {


                Console.WriteLine("Last name cannot be empty");
                return;
            }



    Console.Write("Enter Your Salary: ");
            try
            {
                salary = double.Parse(Console.ReadLine());
                if (salary < 0)
                {
                    throw new Exception("Can not be 0");
                }
               
            }
            catch (Exception ex)
            {
             

                Console.WriteLine("Can not be 0");
                return;
            }




            Employee employee = new Employee(employeeID, firstName, middleName, lastName, salary);
            employee.DisplayEmployeeInfo();






            ITDepartment iTDepartment = new ITDepartment();
            iTDepartment.GetDepartmentDetails();
            iTDepartment.Operate();


            HRDepartment hrDepartment = new HRDepartment();
            hrDepartment.GetDepartmentDetails();
            hrDepartment.Operate();



        }



    }

    
}

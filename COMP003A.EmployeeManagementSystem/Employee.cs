

// Author: [Alvaro Pulido]
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#

/// <summary>
/// Represents an Employee 
/// </summary>
namespace COMP003A.EmployeeManagementSystem
{
    internal class Employee
    {
        // Private Fields

        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        // Public Properties

        public string EmployeeId
        {
            get { return _employeeId; }
        }




        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be empty.");


            }
                _firstName = value;
            } }


        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Middevname cannot be empty.");

                }
                _middleName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last namr cannot be empty.");

                }
                _lastName = value;
            }

        }
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be less than 0");

                }
                _salary = value;
            } }


        // Constructor
        public Employee(string employeeId ,string firstName, string middleName, string lastName ,double salary)
        {
            _employeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            MiddleName = middleName;

        }

        // Methods
        public void PrintFullName()
        {
           

            
                Console.WriteLine($"{FirstName} {LastName}");

                Console.WriteLine($"{FirstName} {MiddleName} {LastName}");
           
        }
        




        public void DisplayEmployeeInfo()
        {
         

            PrintFullName();
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }

}

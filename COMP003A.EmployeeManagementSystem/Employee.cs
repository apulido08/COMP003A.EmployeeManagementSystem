

// Author: [Alvaro Pulido]
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#

/// <summary>
/// Represents an Employee 
/// </summary>
namespace COMP003A.EmployeeManagementSystem
    /// <summary>
    /// Method entering for employee and the details
    /// </summary>
{
    internal class Employee
    {
        // Private Fields

        private readonly string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        // Public Properties

        public string EmployeeId
        {
            get { return _employeeId; }
        }
        /// <summary>
        /// Gets the employee id. also sets it 
        /// </summary>




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
        /// <summary>
        /// Gets the first name, must have an input, cannot be empty
        /// </summary>


        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (value == null)
                {
                    _middleName = string.Empty ;
                }
                _middleName = value;
            }
        }
        /// <summary>
        /// Calls for the middle name. It may be left out.
        /// </summary>

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
        /// <summary>
        /// Calls for the last name input.
        /// </summary>

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

        /// <summary>
        /// calls for the salary to have an input. value cannot be zero.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="salary"></param>


        // Constructor
        public Employee(string employeeId ,string firstName, string middleName, string lastName ,double salary)
        {
            _employeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            MiddleName = middleName;

        }

        /// <summary>
        /// calls for the name to be displayed of the employee
        /// </summary>

        // Methods
        public void PrintFullName()
        {

            if (string.IsNullOrEmpty(MiddleName))
            {
                Console.WriteLine($"{FirstName} {LastName}");
            }

            else
            {
                Console.WriteLine($"{FirstName} {MiddleName} {LastName}");

            }
        }

        /// <summary>
        /// shows full name and employee details 
        /// </summary>
        




        public void DisplayEmployeeInfo()
        {
            
            Console.WriteLine($"Employee {EmployeeId}");
            
            PrintFullName();
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }

}

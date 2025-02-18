// Author: [Alvaro Pulido]
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#

/// <summary>
/// Abstract class for departments
/// </summary>
namespace COMP003A.EmployeeManagementSystem
{
    public abstract class Department
    /// <summary>
    /// Gets and sets the department name
    /// </summary>
    {
        public string DepartmentName
            /// <summary>
            /// dDetails for each department
            /// </summary>
            /// <return> String details for each dep. details </return>
          

        { get; set; }

        public abstract string GetDepartmentDetails();
        /// <summary>
        /// displays the info for the department 
        /// </summary>

        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"{DepartmentName}");
            Console.WriteLine(GetDepartmentDetails());
        }

      

        







    }


}

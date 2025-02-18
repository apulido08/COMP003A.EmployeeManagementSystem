

// Author: [Alvaro Pulido]
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C# 
namespace COMP003A.EmployeeManagementSystem
{
  
   
        public class ITDepartment : Department, IDepartmentOperations
        {/// <summary>
        /// calls the IT department information
        /// </summary>
            public ITDepartment()
            {
                DepartmentName = "Information Technology";
            }

            public override string GetDepartmentDetails()
            {
                return "Details : Manages technical resources and infrastructures,";
            }

            public void Operate()
            {
                Console.WriteLine($"Department: {DepartmentName} ");
            Console.WriteLine(GetDepartmentDetails());
            Console.WriteLine("IT department is maintaning network security.");
            }

            
            
        }
    }

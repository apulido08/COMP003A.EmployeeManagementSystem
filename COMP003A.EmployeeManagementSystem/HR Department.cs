using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    public class HRDepartment : Department, IDepartmentOperations
    {
        public HRDepartment()
        {
            DepartmentName = "Human Resources";

        }

        public override string GetDepartmentDetails()
        {
            return "Handles employees relations and recruitment";
        }

        public void Operate()
        {
            Console.WriteLine("HR department is managing employee onboarding.");
        }
    }
}

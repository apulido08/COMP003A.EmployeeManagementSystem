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
{
    public string DepartmentName
    { get; set; }

    public abstract string GetDepartmentDetails();

public void DisplayDepartmentInfo()
{
    Console.WriteLine($"Department: {DepartmentName}");
    Console.WriteLine(GetDepartmentDetails));
}

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
	

}

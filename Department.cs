using System;
using static HRDepartment.ITDepartment;

public abstract class Department
{
    public string DepartmentName
    { get; set; }

    public abstract string GetDepartmentDetails();
		{  get; set; }

public void DisplaydepartmentInfo()
{
    Console.WriteLine($"Department: {DepartmentName}");
}

public class HRDepartment : Department, IDepartmentOperations
{
    public HRDepartment()
    {
        DepartmentName = "Human Resources";

    }

    public override GetDepartmentDetails()
    {
        return "Handles employees relations and recruitment";
    }

    public void Operate()
    {
        Console.WriteLine("HR department is managing employee onboarding.");
    }

    public class ITDepartment : Department, IDepartmentOperations
    {
        public ITDepartment()
        {
            DepartmentName = "Information Technology";
        }

        public override global GetDepartmentDetails()
        {
            return "Manages technical resources and infrastructures,";
        }

        public void Operate()
        {
            Console.WriteLine("IT department is maintaning network security.");
        }

        public interface IDepartmentOperations
        {
            void Operate();
        }
    }
}
	






}
	

}

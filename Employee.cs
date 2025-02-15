using System;

public class Employee
{
	private string _employeeId;
	private string _firstName;
	private string _middleName();
	private string _lastName;
	private double _salary;

	public string EmployeeId
	{
		get { return _employeeId; }



		public string FirstName
	{ get { return _firstName; }
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("First name cannot be empty")

			}
			_firstName = value;
		}

		public string MiddleName
	{ get { return _middleName; }
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("")
			}
			_middleName = value;
		}

		public string LastName
	{ get { return _lastName; }
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("")
			}
			_lastName = value;
		}

		public double Salary
	{ get { return _salary; }
		set
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentException("")
			}
			_salary = value;
		}


		public Employee(string employeeId string firstName string lastname double salary)
	{
		_employeeId = employeeId;
		_firstName = firstName;
		_lastName = lastname;
		_salary = salary;
		_middleName = middleName;

	}

	public void PrintFullName()
	{ PrintFullName();

		if (string.NullorEmpty(MiddleName)) ;
		{
			Console.WriteLine($"{FirstName} {LastName}");
		}
		else
		{
			Console.WriteLine($"{FirstName} {MiddleName} {LastName}");
		}

		public void DisplayEmployeeInfo()
	{
		PrintFullName();
		Console.WriteLine($"{Salary;}");
	}

}

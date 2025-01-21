// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Day 2 ***");

List<Employee> employees = new List<Employee> {
    new Employee { Id = 1, Name = "Abubaker", Designation = "Manager", Salary = "10000", DoJ = new DateTime(2010, 1, 1) },
    new Employee { Id = 2, Name = "Farhat", Designation = "Developer", Salary = "5000", DoJ = new DateTime(2015, 1, 1) },
    new Employee { Id = 3, Name = "Ahmed", Designation = "TestDesignerer", Salary = "3000", DoJ = new DateTime(2020, 1, 1) },
    new Employee { Id = 4, Name = "Ali", Designation = "Designer", Salary = "4000", DoJ = new DateTime(2018, 1, 1) }
};

Console.WriteLine("Number of Employees: " + employees.Count);
Console.WriteLine("\n| {0,5} | {1,10} | {2,10} | {3,10} | {4,15} |", "Id", "Name", "Designation", "Salary", "Date of Joining");
Console.WriteLine(new string('-', 60));
foreach (var emp in employees)
{
    Console.WriteLine("| {0,5} | {1,10} | {2,10} | {3,10} | {4,15} |", emp.Id, emp.Name, emp.Designation, emp.Salary, emp.DoJ.ToShortDateString());
}


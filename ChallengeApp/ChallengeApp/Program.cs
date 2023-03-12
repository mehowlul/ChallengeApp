using System.Runtime.CompilerServices;
using ChallengeApp;

Employee employee1 = new Employee("Adam", "Kowalski", 29);
Employee employee2 = new Employee("Monika", "Nowak", 33);
Employee employee3 = new Employee("Zuzia", "Wróbel", 28);

employee1.AddScore(1);
employee1.AddScore(1);
employee1.AddScore(1);
employee1.AddScore(1);
employee1.AddScore(1);

employee2.AddScore(3);
employee2.AddScore(3);
employee2.AddScore(3);
employee2.AddScore(3);
employee2.AddScore(3);

employee3.AddScore(4);
employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var Employee in employees)
{
    if (Employee.Result > maxResult)
    {
        employeeWithMaxResult = Employee;
        maxResult = Employee.Result;
    }

}
Console.WriteLine("Pracownik z najwyższą licząbą ocen to: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " (wiek = " + employeeWithMaxResult.Age + ")");
Console.WriteLine("Uzyskany wynik: " + maxResult);
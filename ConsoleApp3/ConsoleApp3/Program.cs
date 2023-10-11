using System;

class Employee
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Position { get; set; }
    public int Experience { get; set; }

    public Employee(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }

    public double CalculateSalary()
    {
       
        double baseSalary = 20000;
        double experienceBonus = Experience * 500;
        return baseSalary + experienceBonus;
    }

    public double CalculateTax()
    {
      
        double salary = CalculateSalary();
        return salary * 0.2; 
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введіть прізвище співробітника: ");
        string lastName = Console.ReadLine();

        Console.Write("Введіть ім'я співробітника: ");
        string firstName = Console.ReadLine();

        Console.Write("Введіть посаду співробітника: ");
        string position = Console.ReadLine();

        Console.Write("Введіть стаж співробітника (у роках): ");
        if (!int.TryParse(Console.ReadLine(), out int experience))
        {
            Console.WriteLine("Неправильний формат для стажу.");
            return;
        }

        Employee employee = new Employee(lastName, firstName)
        {
            Position = position,
            Experience = experience
        };

        double salary = employee.CalculateSalary();
        double tax = employee.CalculateTax();

        Console.WriteLine("Інформація про співробітника:");
        Console.WriteLine($"Прізвище: {employee.LastName}");
        Console.WriteLine($"Ім я: {employee.FirstName}");
        Console.WriteLine($"Посада: {employee.Position}");
        Console.WriteLine($"Оклад: {salary:C}");
        Console.WriteLine($"Податковий збір: {tax:C}");
    }
}
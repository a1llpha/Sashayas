using System;

class User
{
    public string Login { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime RegistrationDate { get; }

    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegistrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine("Інформація про користувача:");
        Console.WriteLine($"Логін: {Login}");
        Console.WriteLine($"Ім'я: {FirstName}");
        Console.WriteLine($"Прізвище: {LastName}");
        Console.WriteLine($"Вік: {Age} років");
        Console.WriteLine($"Дата реєстрації: {RegistrationDate:yyyy-MM-dd HH:mm:ss}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введіть логін: ");
        string login = Console.ReadLine();

        Console.Write("Введіть ім'я: ");
        string firstName = Console.ReadLine();

        Console.Write("Введіть прізвище: ");
        string lastName = Console.ReadLine();

        Console.Write("Введіть вік: ");
        if (!int.TryParse(Console.ReadLine(), out int age))
        {
            Console.WriteLine("Неправильний формат для віку.");
            return;
        }

        User user = new User(login, firstName, lastName, age);

        user.DisplayUserInfo();
    }
}

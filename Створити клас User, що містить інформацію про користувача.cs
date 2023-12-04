using System;

class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate; // Поле, яке можна ініціалізувати лише один раз

    // Конструктор класу User
    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.registrationDate = DateTime.Now; // Ініціалізація дати заповнення анкети
    }

    // Метод для виведення інформації на екран
    public void DisplayUserInfo()
    {
        Console.WriteLine("Інформація про користувача:");
        Console.WriteLine($"Логін: {login}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Вік: {age} років");
        Console.WriteLine($"Дата заповнення анкети: {registrationDate}");
    }
}

class Program
{
    static void Main()
    {
        // Створюємо екземпляр класу User
        User user = new User("user123", "Іван", "Петров", 25);

        // Викликаємо метод для виведення інформації на екран
        user.DisplayUserInfo();

        Console.ReadLine(); // Затримка, щоб консольне вікно не закрилося відразу
    }
}

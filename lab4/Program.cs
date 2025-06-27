namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        // Завдання 1
        Console.WriteLine("Завдання 1");
        int age = 17;
        double weight = 63.9;
        char grade = 'A';
        bool isStudent = true;
        string name = "Ілля";
        Console.WriteLine("Вік: " + age);
        Console.WriteLine("Вага: " + weight);
        Console.WriteLine("Оцінка: " + grade);
        Console.WriteLine("Студент: " + isStudent);
        Console.WriteLine("Ім'я: " + name);
        Console.WriteLine();

        // Завдання 2
        Console.WriteLine("Завдання 2");
        Console.Write("Введіть дробове число: ");
        string input = Console.ReadLine();
        double doubleValue = Convert.ToDouble(input);
        Console.WriteLine("Double: " + doubleValue);
        int intValue = (int)doubleValue;
        Console.WriteLine("Int: " + intValue);
        string stringValue = intValue.ToString();
        Console.WriteLine("String: " + stringValue);
        Console.WriteLine();

        // Завдання 3
        Console.WriteLine("Завдання 3");
        Console.Write("Напишіть своє ім'я: ");
        string userName = Console.ReadLine();
        Console.Write("Введіть ваш вік: ");
        int userAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Привіт, {userName}! Твій вік: {userAge} років.");
        Console.WriteLine();

        // Завдання 4
        Console.WriteLine("Завдання 4");
        Console.Write("Введіть відстань в км: ");
        double distance = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть час: ");
        double time = Convert.ToDouble(Console.ReadLine());
        double speed = distance / time;
        Console.WriteLine($"Середня швидкість: {speed} км/год");
        Console.WriteLine();

        // Завдання 5
        Console.WriteLine("Завдання 5");
        Console.Write("Введіть речення: ");
        string sentence = Console.ReadLine();
        Console.WriteLine($"Довжина: {sentence.Length} символів");
        Console.WriteLine($"Верхній регістр: {sentence.ToUpper()}");
        Console.WriteLine($"Замінені пробіли: {sentence.Replace(" ", "_")}");
        Console.WriteLine($"Перші 5 символів: {sentence.Substring(0, 5)}");
    }
}


using System;

public sealed class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();

    private Logger() { }

    public static Logger Instance
    {
        get
        {
            lock (_lock)
            {
                return _instance ??= new Logger();
            }
        }
    }

    public void Log(string msg)
    {
        Console.WriteLine($"{DateTime.Now}: {msg}");
    }
}

public interface INotification
{
    void Send(string message);
}

public class EmailNotification : INotification
{
    public void Send(string message) => Console.WriteLine($"Email: {message}");
}

public class SMSNotification : INotification
{
    public void Send(string message) => Console.WriteLine($"SMS: {message}");
}

public class PushNotification : INotification
{
    public void Send(string message) => Console.WriteLine($"Push: {message}");
}

public static class NotificationFactory
{
    public static INotification Create(string type)
    {
        return type.ToLower() switch
        {
            "email" => new EmailNotification(),
            "sms" => new SMSNotification(),
            "push" => new PushNotification(),
            _ => throw new ArgumentException("Невідомий тип повідомлення")
        };
    }
}

public class Computer
{
    public string CPU { get; set; }
    public string GPU { get; set; }
    public int RAM { get; set; }
    public int SSD { get; set; }

    public void Show()
    {
        Console.WriteLine($"Комп’ютер: CPU={CPU}, GPU={GPU}, RAM={RAM}GB, SSD={SSD}GB");
    }
}

public class ComputerBuilder
{
    private Computer _computer = new Computer();

    public ComputerBuilder SetCPU(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }

    public ComputerBuilder SetGPU(string gpu)
    {
        _computer.GPU = gpu;
        return this;
    }

    public ComputerBuilder SetRAM(int ram)
    {
        _computer.RAM = ram;
        return this;
    }

    public ComputerBuilder SetSSD(int ssd)
    {
        _computer.SSD = ssd;
        return this;
    }

    public Computer Build()
    {
        return _computer;
    }
}

class Program
{
    static void Main()
    {
        // Завдання 1
        var logger1 = Logger.Instance;
        var logger2 = Logger.Instance;

        logger1.Log("Це перше повідомлення");
        logger2.Log("Це друге повідомлення");

        Console.WriteLine($"Однакові екземпляри: {ReferenceEquals(logger1, logger2)}\n");

        // Завдання 2
        Console.Write("Тип повідомлення (email/sms/push): ");
        string type = Console.ReadLine();

        try
        {
            var notification = NotificationFactory.Create(type);
            notification.Send("Привіт, користувачу!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }

        Console.WriteLine();

        // Завдання 3
        var gamingPC = new ComputerBuilder()
            .SetCPU("AMD Ryzen 9 7950X")
            .SetGPU("AMD Radeon RX 7900 XTX")
            .SetRAM(64)
            .SetSSD(2000)
            .Build();

        var officePC = new ComputerBuilder()
            .SetCPU("Intel i3")
            .SetGPU("Intel UHD Graphics")
            .SetRAM(8)
            .SetSSD(256)
            .Build();

        Console.WriteLine("Конфігурація Gaming PC:");
        gamingPC.Show();

        Console.WriteLine("\nКонфігурація Office PC:");
        officePC.Show();
    }
}
// Завдання 1
/*
using System;

public class Container<T>
{
    public T Value { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Значення: {Value}, Тип: {Value.GetType().Name}");
    }
}

class Program
{
    static void Main()
    {
        Container<int> intBox = new Container<int> { Value = 42 };
        Container<string> strBox = new Container<string> { Value = "Hello" };

        intBox.ShowInfo();
        strBox.ShowInfo();
    }
}
*/

// Завдання 2

using System;

class Program
{
    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("В масиві пусто");

        T max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i].CompareTo(max) > 0)
                max = array[i];
        }

        return max;
    }

    static void Main()
    {
        int[] intArray = { 12, 4, 7, 15, 9 };
        double[] doubleArray = { 2.3, 6.7, 5.5, 8.8 };
        string[] stringArray = { "orange", "grape", "melon" };

        Console.WriteLine($"Максимум: {FindMax(intArray)}");
        Console.WriteLine($"Максимум: {FindMax(doubleArray)}");
        Console.WriteLine($"Максимум: {FindMax(stringArray)}");
    }
}

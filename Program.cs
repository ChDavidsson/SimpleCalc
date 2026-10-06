namespace SimpleCalc;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to a simple calculator!");
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine()!);


        Console.WriteLine($"Addition: {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1 * num2}");
        Console.WriteLine($"Division: {num1 / num2}");
    }
}

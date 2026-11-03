using CalculatorSolution;


Console.WriteLine("Простой калькулятор .NET 10");
Console.WriteLine("Доступные операции: +, -, *, /");
Console.Write("Введите выражение (например, 2 + 3): ");

var input = Console.ReadLine();
if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Пустой ввод.");
    return;
}

var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
if (parts.Length != 3 || !int.TryParse(parts[0], out var left) || !int.TryParse(parts[2], out var right))
{
    Console.WriteLine("Неверный формат. Используйте: число операция число");
    return;
}

var operation = parts[1];
try
{
    var result = operation switch
    {
        "+" => Calculator.Add(left, right),
        "-" => Calculator.Subtract(left, right),
        "*" => Calculator.Multiply(left, right),
        "/" => Calculator.Divide(left, right),
        _ => throw new ArgumentException($"Неизвестная операция: {operation}")
    };
    Console.WriteLine($"Результат: {result}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
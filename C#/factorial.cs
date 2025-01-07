// Factorial

Console.Write("Enter your number :");

int number =int.Parse(Console.ReadLine());

int result = number;
Console.WriteLine(result);
for (int counter = number-1; counter > 0 ; counter--)
{
    Console.Write($"*{counter}");
    result = result * counter;
}
Console.Write($" =  {result}");
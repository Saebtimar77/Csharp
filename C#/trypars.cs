//swith cullculate
Console.Write("Wellcom");
Console.WriteLine("1[+].add ");
Console.WriteLine("2[-].substract");
Console.WriteLine("3[*].multy");
Console.WriteLine("4[/].devide");
Console.WriteLine("Enter you option : ");
var option = Console.ReadLine();
if (option != "1" && option != "2" && option != "3" && option != "4" && option != "+" && option != "-" && option != "*" && option != "/")
{
    Console.WriteLine("number invalid");
    return;
}
Console.WriteLine("first number: ");
bool numberIsconverted= int.TryParse(Console.ReadLine() , out int number1);
if (!numberIsconverted )
{
    Console.WriteLine("pleas just enter a number ");
    return;
}
//var number1 = int.Parse(Console.ReadLine());
Console.WriteLine("second number: ");
bool numberisconverted=int.TryParse(Console.ReadLine() , out int number2);
if (!numberisconverted) 
{
    Console.WriteLine("pleas just enter a number ");
    return;
}

//var number2 = int.Parse(Console.ReadLine());
switch (option)
{
    case "1":
    case "+":
        Console.WriteLine($"{number1}+{number2}={number1 + number2}");
        break;
    case "2":
    case "-":
        Console.WriteLine($"{number1}-{number2}={number1 - number2}");
        break;
    case "3":
    case "*":
        Console.WriteLine($"{number1}*{number2}={number1 * number2}");
        break;
    case "/":
    case "4":
        if (number2 == 0)
        {
            Console.WriteLine("not devided by zero");
            return;
        }
        Console.WriteLine($"{number1}/{number2}={number1 / number2}");
        break;

}

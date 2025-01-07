// mashin hesab
using System.Globalization;

while (true)
{
    Console.Clear();
    Console.WriteLine("Wellcom to my app");
    Console.WriteLine("1. add");
    Console.WriteLine("2. subtract");
    Console.WriteLine("3. multiply");
    Console.WriteLine("4. devide");
    Console.WriteLine("5. avrage");
    Console.WriteLine("6. factorial");
    Console.WriteLine("7. Exit");
    Console.Write("Pleas Chose your option:");
    if(!int.TryParse(Console.ReadLine(), out int option)|| option>7 || option<1)
    {
        Console.WriteLine("Pleas just Enter nuumber ");
        Console.ReadKey();
        continue;
    }

    if (option == 5)
    {
        Console.Write("How many number for calculate: ");
        if (!int.TryParse(Console.ReadLine(),out int number))
        {
            Console.WriteLine("Plaes just enter numer");
            Console.ReadKey();
            continue;
        }
         int sum = 0;
        for (int i = 1; i <= number; i++)
        {
            Console.Write($"{i}st:");
            if(!int.TryParse(Console.ReadLine(),out int num))
            {
                Console.WriteLine("just number");
                Console.ReadKey(); 
                continue;

            }
          sum += num;

        }
        Console.WriteLine($"sum of is avrage: {sum/number}");
        Console.WriteLine($"sum of is: {sum}");
        Console.ReadKey();
        continue;
    }

    if (option == 6)
    {
        Console.Write("Enter a number for factorial :");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("just number");
            Console.ReadKey();
            continue;
        }
            int sum = number;
            for (int i = number-1;i > 0; i--)
            {
               sum = sum * i;
               
            }
        Console.WriteLine(sum);
        Console.ReadKey();
        continue;
    } 
    if (option == 7)
    {
        break;
    }

    












}

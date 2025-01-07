while (true) {
    Console.Clear();
    Console.WriteLine("Wellcom to my app");
    Console.WriteLine("---------------------------");
    Console.WriteLine("1. add");
    Console.WriteLine("2. subtract");
    Console.WriteLine("3. multiply");
    Console.WriteLine("4. devide");
    Console.WriteLine("5. avrage");
    Console.WriteLine("6. factorial");
    Console.WriteLine("7. Exit");
    Console.Write("Pleas chose an option: ");
    if (!int.TryParse(Console.ReadLine(), out int option )|| option<1 || option>7 )
{
        Console.WriteLine("Pleas only just enter number!!");
        Console.ReadKey();
        continue;
}

    if (option == 5)
    {
        Console.WriteLine("How many avrage calculate");
        if (!int.TryParse(Console.ReadLine(), out int avrage))
        {
            Console.WriteLine("Pleas just only enter number for avrage");
            Console.ReadKey();
            continue;
        }
            int sum = 0;
            for (int i = 1; i <= avrage; i++)
            {
                Console.Write($"{i}st:");
                 if (!int.TryParse(Console.ReadLine(), out int number))
                 {
                     Console.WriteLine("Pleas just only number");
                      Console.ReadKey();
                      continue;
                 }
            sum += number;


            }
        Console.WriteLine($"sum of number is :{sum / avrage}");
        Console.ReadKey();
            continue;
    }
    



    if (option == 6)
    {
        Console.WriteLine("pleas enter number for calculat factoral:");
        if (!int.TryParse(Console.ReadLine(), out int factorial))
        {
            Console.WriteLine("pleas just enter number ");
            Console.ReadKey();
            continue;
        }   
            int result = factorial;
            for (int i = factorial-1; i > 0; i--)
            {
                result = result * i;
             
            } 
            Console.WriteLine(result);
            Console.ReadKey();
            continue;
        
    }
    if (option == 7)
    {
        break;
    }

    Console.Write("ENTER FIRST NUMBER:");
    if (!int.TryParse(Console.ReadLine(),out int number1))
    {
        Console.WriteLine("PLEAS JUST ENTER NUMBER FOR NEX ANY PRESS KEY");
        Console.ReadKey();
        continue;
    }

    Console.Write("ENTER SCOND NUMBER:");
    if (!int.TryParse(Console.ReadLine(), out int number2))
    {
        Console.WriteLine("PLEAS JUST ENTER NUMBER FOR NEX ANY PRESS KEY");
        Console.ReadKey();
        continue;
    }

    switch(option)
    {
        case 1:
            Console.WriteLine($"{number1}+{number2}={number1+number2}");
            Console.ReadKey();
            break;
        case 2:
            Console.WriteLine($"{number1}-{number2}={number1-number2}");
            Console.ReadKey();
            break;
        case 3:
            Console.WriteLine($"{number1}*{number2}={number1*number2}");
            Console.ReadKey();
            break;
        case 4:
            if (number2 == 0)
            {
                Console.WriteLine("NOT DEVIDE BY ZERO");
                Console.ReadKey();
                continue ;
            }
            Console.WriteLine($"{number1}/{number2}={number1/number2}");
            Console.ReadKey();
            break;
    }


    























































}//Loops while






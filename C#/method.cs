// C# Method


void Displaymessage()
{
    Console.WriteLine("Wellcom to my room");
}
Displaymessage();
Displaymessage();

// mthod with parameters

void Displayprametersmessage(string message)
{
    Console.WriteLine(message);
}
Displayprametersmessage("wellcom bro");
Displayprametersmessage("keep going");

// mwthod with multiple parameters

void Repeatmessage(string message,int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(message);
    }
}
    Repeatmessage("good louk",4);

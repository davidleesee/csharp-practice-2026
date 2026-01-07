Console.WriteLine("let's do some math! Give me your first number...");
int numberOne = int.Parse(Console.ReadLine());

Console.WriteLine($"Awesome! Your first number is {numberOne}. What's your second number?");
int numberTwo =int.Parse(Console.ReadLine());

Console.WriteLine($"Thanks! Your second number is {numberTwo}. What operation would you like to perform? (+, -, *, /)");
string operation = Console.ReadLine();

int result = 0;

if (operation == "+")
{
    result = numberOne + numberTwo;
}
else if (operation == "-")
{
    result = numberOne - numberTwo;
}
else if (operation == "*")
{
    result = numberOne * numberTwo;
}
else if (operation == "/")
{
    result = numberOne / numberTwo;
}
else
{
    Console.WriteLine("Invalid operation selected.");
    return;
}

Console.WriteLine($"Great! You chose to {operation} the numbers {numberOne} and {numberTwo}. The answer is {result}");
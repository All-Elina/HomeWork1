/*
// Задача 1.
// Напишите программу, которая на вход принимает два числа
// и выдает, какое число большее, а какое меньшее
Console.Write("Input your 1st number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your 2nd number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number2 > number1)
{
    Console.WriteLine($"Your second number is a max, your first number is a min");
}
else
{
    Console.WriteLine($"Your first number is a max, your second number is a min");
}
*/


//Задача 2.
//Напишите программу, которая принимает на вход три числа и выдает максимаьное из этих чисел
Console.Write("Input your 1st number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your 2nd number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your 3rd number: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if(number2 > max)
{
    max = number2;
}
if(number3 > max)
{
    max = number3;
}
Console.WriteLine("max = " + max);


/*
//Задача 3.
//Напишите программу, которая на вход принимает число и выдает, 
//является ли число четным (делится ли оно на два без остатка)
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int dev = number % 2;
if(number % 2 == 0)
{
    Console.WriteLine($"Your second number is even");
}
else
{
    Console.WriteLine($"Your second number is odd!");
}
*/
/*
//Задача 4.
//Напишите программу, которая на вход принимает число N, а на выходе показывает
//все четные числа от 1 до number
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int even_number = 2;
if(number > 1)
{
    while(even_number <= number)
    {
        Console.Write(even_number + " ");
        even_number = even_number + 2;
    }
}
*/
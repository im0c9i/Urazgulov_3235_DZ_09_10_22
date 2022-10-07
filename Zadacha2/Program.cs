/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */ 

void GetNumber(int number)
{
    Console.Write ($"{number} ->");

    for (int i = 1; i <= number; i++)
    {
    int kvadrat = i*i*i;
    Console.Write($" {kvadrat}, ");

    }
}
System.Console.WriteLine("Введите число N: ");
int num = int.Parse(Console.ReadLine());
GetNumber(num);
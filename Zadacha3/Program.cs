/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/ 
System.Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
int num = number.Length;
if(num == 5)
{
    if(number[0] == number[4] && number[1] == number[3])
    System.Console.WriteLine($"Число {number} палиндром");

else

    System.Console.WriteLine($"Число {number} не палиндром");
}
else System.Console.WriteLine("Число не пятизначное");

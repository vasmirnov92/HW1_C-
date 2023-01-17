// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());

string chetnost = "четное";
int ostatok = number % 2;

if (ostatok == 0) chetnost = "четное";
else chetnost = "нечетное";

Console.Write ("Введенное число: ");
Console.WriteLine (chetnost);
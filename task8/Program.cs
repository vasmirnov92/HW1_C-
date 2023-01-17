// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
int list = 2;

while (list <= number)
{    
    Console.Write (list);
    Console.Write (" ");
    list = list + 2;
}
}

else if (number < 0)
{
int list = -2;

while (list >= number)
{    
    Console.Write (list);
    Console.Write (" ");
    list = list - 2;
}

}



// Console.Write ("Введенное число: ");
// Console.WriteLine (chetnost);
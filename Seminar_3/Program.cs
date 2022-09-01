// Console.WriteLine("Введите X: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("1");
// }
// if (x < 0 && y > 0)
// {
//     Console.WriteLine("2");
// }
// if (x < 0 && y < 0)
// {
//     Console.WriteLine("3");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine("4");
// }

// Console.WriteLine("Введите X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double b = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-1,2));
// Console.WriteLine(b);

// Console.WriteLine("Введите цифру");
// int N = Convert.ToInt32(Console.ReadLine());
// int index = 1;

// Console.WriteLine();

// while(index<=N)
// {
//     Console.WriteLine(Math.Pow(index,2));
//     index++;
// }

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Write("Введите пятизначаное  число: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number)
// {
//   if (number[0]==number[4] && number[1]==number[3])
//   {
//     Console.WriteLine($"Ваше число: {number} - Число явяляется палиндромом.");
//   }
//   else Console.WriteLine($"Ваше число: {number} - Число не является палиндромом.");
// }

// if (number!.Length == 5)
// {
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Совершенно не понимаю как решать

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

Console.WriteLine();

while(index<=N)
{
    Console.WriteLine(Math.Pow(index,3));
    index++;
}
// Напишите программу, которая принимает на вход число (A) и выдаёт сумму чисел от 1 до A.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сумма = " + GetSum(num) );

// int GetSum(int number)
// {
//     int sum = 0;
//     int count = 0;
//         while(number > count)
//         {
//             count++;
//             sum += count;
//         }
//         return sum;
// }


// Напишите программу, которая принимает на вход число и выдат количество цифр в числе.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = Convert.ToString(num);
// Console.WriteLine("Количество цифр-" + ColvoCifr(result));

// int ColvoCifr(string num)
// {
//     int size = num.Length;
//     return size;
// }

// Напишите программу, котора на вход принимает число N и выдаёт произведение чисел от 1 до N.

// Console.WriteLine("Ведите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num + "->" + GetSum(num));

// int GetSum(int number)
// {
//     int pr = 1;
//     int count = 0;
//     while(number > count)
//     {
//         count++;
//         pr *= count;
//     }
//     return pr;
// }

// int []array = GetArray(8);
// Console.WriteLine(string.Join(",",array));

// int [] GetArray(int size)
// {
//     int[] result = new int [size];
//     for(int i=0; i < size; i++ )
//     {
//         result[i] = new Random().Next(0,9);
//     }
//     return result;
// }

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число 1");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Pow(A, B));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр в числе равна: " + SumNum(num));

int SumNum(int num)
{
    
    int counter = Convert.ToString(num).Length;  
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = num - num % 10;
      result = result + (num - advance);
      num = num / 10;
    }
   return result;
  }
  //не пониманию как работает эта программа , напишите мне пожалуйста в личные сообщения на GB и обьясните, будьте добры

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int []array = GetArray(8);
Console.WriteLine(string.Join(",",array));

int [] GetArray(int size)
{
    int[] result = new int [size];
    for(int i=0; i < size; i++ )
    {
        result[i] = new Random().Next(0,9);
    }
    return result;
}
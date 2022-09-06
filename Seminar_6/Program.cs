//Задача №39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый на последнем и т.д.)

// int [] array = GetArray(10,0,10);
// Console.WriteLine(String.Join(",",array));

// ReversArray(array);
// Console.WriteLine(String.Join(",",array));

// int [] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int [size];
//     for( int i=0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
// void ReversArray(int [] inArray)
// {
//     for(int i = 0; i < inArray.Length/2; i++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length - 1 -i];
//         inArray[inArray.Length-1-i] = k;
//     }
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = 0;

// while(num!=0)
// {
//     int value = 6;
//     string binary = Convert.ToString(value,2);
// // }
// Console.WriteLine(binary);

// Переведите число из десятичной системы в двоичную

// void ConvertNum(int number)
// {
//     string result = "";
//     while(number > 0)
//     {
//         result = number%2 + result;
//         number/=2;
//     }
//     Console.WriteLine(result);
// }
// int input = Convert.ToInt32(Console.ReadLine());
// ConvertNum(input);

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int firstN = 0;
// int secondN = 1;
// Console.Write(firstN + ",");
// Console.Write(secondN);

// for(int i = 3; i <= num; i++)
// {
//     int newN = firstN + secondN;
//     Console.Write("," + newN);
//     firstN = secondN;
//     secondN = newN;
// }
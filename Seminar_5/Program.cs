// Задача №31
// Задайте массив из 12 элементов, заполненный случчайными цифрами из промежутка [-9, 9].
// Найдите сумму отрицательных и полжительных элементов массива. Например,  в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных числе равна -20.

// int [] array = new int [12];
// int size = array.Length;

// int positivSum = 0;
// int negativSum = 0;

// for(int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     if(array[i]>0)
//     {
//         positivSum += array[i];
//     }
//     else
//     {
//         negativSum += array[i];
//     }
// }
// Console.WriteLine("Сумма положительных чисел = " + positivSum + " | Сумма отрицательных чисел = "+ negativSum );
// Console.WriteLine(String.Join(",", array));

// Задача №37
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

// int[] inputArray = {1,2,3,4,5};

// int[] resultArray = new int [inputArray.Length/2 + inputArray.Length%2];

// for(int i = 0; i < resultArray.Length; i++)
// {
//     resultArray[i] = inputArray[i] * inputArray[inputArray.Length-1-i];
//     if(i==(inputArray.Length-1-i))
//     {
//         resultArray[i] = inputArray[i];
//     }
// }
// Console.WriteLine(String.Join(",",resultArray));

//Задайте массив и сделайте все элементы массива с обратным значением + или -.

// int[] array = {-4,-8,8,2};
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] *= -1;
// }
// Console.WriteLine("[{0}]", String.Join(",",array));


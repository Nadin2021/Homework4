/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

Console.Write ("Введите число A:  ");
int numberA = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите число B:  ");
int numberB = Convert.ToInt32 (Console.ReadLine());

double  result = Math.Pow(numberA,numberB);
Console.WriteLine(result);
*/


/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

int SumNumb(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

Console.Write ("Введите число:  ");
int num = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Сумма чисел " + SumNumb(num));
*/


/*
Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*int [] arr = { 1, 2, 5, 7, 19 };

void PrintArray ( int [] array)
{
    int count = array.Length;
    for (int i=0; i<count; i++)
    {
        Console.Write ( $"{array[i]} " );
    }
    Console.WriteLine();
}
PrintArray(arr);
*/
int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);




/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
Console.Write ("Введите 5 значное число:  ");
int num = Convert.ToInt32 (Console.ReadLine());

int num1 = num % 10;
int num2 = num % 100 / 10;
int num3 = num % 1000 / 100;
int num4 = num % 10000 / 1000;
int num5 = num % 100000/10000;

int Newnum = (num1 * 10000 + num2 * 1000 + num3 * 100 + num4 * 10 + num5);

if ( num == Newnum)
{
  Console.WriteLine ("Yes");
}
else
{
  Console.WriteLine ("No");
}
*/

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double result = Math.Sqrt(Math.Pow((xB - xA),2)+Math.Pow((yB - yA),2)+Math.Pow((zB - zA),2));
    return result;
}
Console.WriteLine("Input coordinate xA =");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate yA =");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate zA =");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate xB =");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate yB =");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate zB =");
double zB = Convert.ToDouble(Console.ReadLine());


double distanse = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine(distanse); 
*/

/*_____________________________________________________________
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125



Console.Write ( "Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

    int current = 1;

    while (current <= n)
    {
        Console.Write (current *current*current + " ");
        current += 1;
    }
*/

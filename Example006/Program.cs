﻿// Привет Маша-необычно только для Маши
Console.Write ( "Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine ("Ура! Привет Маша!");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine(username);
}

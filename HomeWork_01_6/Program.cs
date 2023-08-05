/* Задание 6
Пользователь вводит с клавиатуры показания тем-
пературы. В зависимости от выбора пользователя про-
грамма переводит температуру из Фаренгейта в Цельсий
или наоборот.*/

Console.Write("Введите температуру(C°): ");
double t = Convert.ToDouble(Console.ReadLine());
Console.Write("Перевести: в Цельсий(c), Фаренгейт(f): ");
var measure = Console.ReadLine();

switch (measure)
{
    case "c":
        Console.WriteLine(t);
        break;
    case "f":
        Console.WriteLine((t*9/5)+32);
        break;
}

// не уверен что правильно понял условие задачи

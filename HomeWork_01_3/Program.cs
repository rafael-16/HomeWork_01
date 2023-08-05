/* Задание 3
Пользователь вводит с клавиатуры четыре цифры.
Необходимо создать число, содержащее эти цифры. На-
пример, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
сформировать число 1578.*/

int num1, num2, num3, num4, num5;

Console.Write("Введите 1-ю цифру: ");
num1 = Convert.ToInt32(Console.ReadLine());

while (num1 > 9)
{
    Console.Write("Введите цифру, а не число: ");
    num1 = Convert.ToInt32(Console.ReadLine());
}
    Console.Write("Введите 2-ю цифру: ");
num2 = Convert.ToInt32(Console.ReadLine());

while (num2 > 9)
{
    Console.Write("Введите цифру, а не число: ");
    num2 = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите 3-ю цифру: ");
num3 = Convert.ToInt32(Console.ReadLine());

while (num3 > 9)
{
    Console.Write("Введите цифру, а не число: ");
    num3 = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите 4-ю цифру: ");
num4 = Convert.ToInt32(Console.ReadLine());

while (num4 > 9)
{
    Console.Write("Введите цифру, а не число: ");
    num4 = Convert.ToInt32(Console.ReadLine());
}

num5 = num1 * 1000 + num2 * 100 + num3 * 10 + num4; //хотя строковым наверное проще было бы
Console.WriteLine(num5);
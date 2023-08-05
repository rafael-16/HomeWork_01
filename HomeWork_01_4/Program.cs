/* Задание 4
Пользователь вводит шестизначное число. После чего
пользователь вводит номера разрядов для обмена цифр.
Например, если пользователь ввёл один и шесть — это
значит, что надо обменять местами первую и шестую
цифры.
Число 723895 должно превратиться в 523897.
Если пользователь ввел не шестизначное число тре-
буется вывести сообщение об ошибке.*/


Console.Write("Введите 6-значное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 100000 || num > 1000000)
{
    Console.Write("Ошибка! Введите 6-значное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите разряды числа (1-6), которые желаете поменять.");
Console.Write("Первый: ");
int digit1= Convert.ToInt32(Console.ReadLine());
while(digit1<1|| digit1 > 6)
{
    Console.Write("Ошибка! Введите от 1 до 6: ");
    digit1 = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Второй: ");
int digit2= Convert.ToInt32(Console.ReadLine());
while (digit2 < 1 || digit2 > 6)
{
    Console.Write("Ошибка! Введите от 1 до 6: ");
    digit2 = Convert.ToInt32(Console.ReadLine());
}


char[] array = num.ToString().ToArray();

var temp = array[digit1-1];
array[digit1-1] = array[digit2-1];
array[digit2 - 1] = temp;

foreach (var item in array)
{
    Console.Write($"{item}");
}
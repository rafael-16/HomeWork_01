/* Задание 1
Пользователь вводит с клавиатуры число в диапа-
зоне от 1 до 100. Если число кратно 3 (делится на 3 без
остатка) нужно вывести слово Fizz. Если число кратно 5
нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
вывести само число.
Если пользователь ввел значение не в диапазоне от 1
до 100 требуется вывести сообщение об ошибке.*/

Console.Write("Введите число от 1 до 100: ");
int num;
num = Convert.ToInt32(Console.ReadLine());

while (num < 1 || num > 100)
{
    Console.Write("Вы вели неверно!\n" +
        "Введите число от 1 до 100: ");
    num = Convert.ToInt32(Console.ReadLine());
}

if (num % 3 == 0 && num % 5 == 0)
{
    Console.WriteLine("Fizz Buzz");
}
else if (num % 3 == 0)
{
    Console.WriteLine("Fizz");
}
else if (num % 5 == 0)
{
    Console.WriteLine("Buzz");
}
else
{
    Console.WriteLine(num);
}

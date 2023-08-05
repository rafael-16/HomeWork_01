/* Задание 7
Пользователь вводит с клавиатуры два числа. Нужно
показать все четные числа в указанном диапазоне. Если
границы диапазона указаны неправильно требуется про-
извести нормализацию границ. Например, пользователь
ввел 20 и 11, требуется нормализация, после которой
начало диапазона станет равно 11, а конец 20.*/

Console.Write("Введите два числа через\n" +
    "пробел или запятую: ");
var numbers=Console.ReadLine();

var numarray = numbers.Split(' ',',');
int num1 = Convert.ToInt32(numarray[0]);
int num2 = Convert.ToInt32(numarray[1]);

if (num1 > num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

Console.WriteLine("Первое число: " +  num1);
Console.WriteLine("Второе число: " +  num2);

for(int i = num1; i <= num2; i++)
{
    if (i % 2 == 0) Console.Write($"{i}, ");
}
/* Задание 2
Пользователь вводит с клавиатуры два числа. Первое
число — это значение, второе число процент, который
необходимо посчитать. Например, мы ввели с клавиатуры
90 и 10. Требуется вывести на экран 10 процентов от 90.
Результат: 9.*/

float number;
float percent;
float result;

Console.Write("Введите 1-ое число: ");
number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-ое число: ");
percent = Convert.ToInt32(Console.ReadLine());

result = number /  100 * percent;
Console.WriteLine(percent + "% от числа " + number + " = " + result);
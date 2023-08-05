/* Задание 5
Пользователь вводит с клавиатуры дату. Приложе-
ние должно отобразить название сезона и дня недели.
Например, если введено 22.12.2021, приложение должно
отобразить Winter Wednesday.*/


Console.Write("Введите дату в формате дд.мм.гггг: ");
DateTime date = DateTime.Parse(Console.ReadLine());
Console.WriteLine(date);

if (date.Month == 12 || date.Month == 1 || date.Month == 2)
{
    Console.WriteLine("Время года: Зима\n" +
        "День недели: " + date.DayOfWeek);
}
else if (date.Month == 3 || date.Month == 4 || date.Month == 5)
{
    Console.WriteLine("Время года: Весна\n" +
    "День недели: " + date.DayOfWeek);
}
else if (date.Month == 6 || date.Month == 7 || date.Month == 8)
{
    Console.WriteLine("Время года: Лето\n" +
    "День недели: " + date.DayOfWeek);
}
else if (date.Month == 9 || date.Month == 10 || date.Month == 11)
{
    Console.WriteLine("Время года: Осень\n" +
    "День недели: " + date.DayOfWeek);
}

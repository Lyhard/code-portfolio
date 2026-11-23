string password = "1234";
for (int i = 0; i < 3; i++)
{
    Console.Write("Введите пароль: ");
    string UserPassword = Console.ReadLine();
    if (UserPassword == password)
    {
        Console.WriteLine("Доступ разрешён!");
        break;
    }
    if (UserPassword != password && i < 2)
    {
        Console.WriteLine($"Доступ запрещён! Осталось попыток: {2 - i}");
    }
    if (UserPassword != password && i == 2)
    {
        Console.WriteLine("Доступ запрещён! Больше попыток нет!");
    }
}
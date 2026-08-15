using System.ComponentModel;
using System.Diagnostics;

ApplicationRegistry registry = new ApplicationRegistry();
while (true)
{
    Console.Write("Введите команду: ");
    string? command = Console.ReadLine()?.ToLower();
    if (command != null && command.StartsWith("открой "))
    {
        command = command.Substring("открой ".Length).Trim();
        ApplicationInfo? applicationInfo = registry.GetApplication(command);
        if (applicationInfo != null)
        {
            try
            {
                if (applicationInfo.Arguments == null)
                {
                    Process.Start(applicationInfo.Path);
                    Console.WriteLine($"Запускаю приложение: {command}...");
                }
                else
                {
                    Process.Start(applicationInfo.Path, applicationInfo.Arguments);
                    Console.WriteLine($"Запускаю приложение: {command}...");
                }
            }
            catch (Win32Exception)
            {
                Console.WriteLine($"Ошибка при запуске приложения {command}");
            }
        }
        else
        {
            Console.WriteLine($"Приложение {command} не найдено");
        }
    }
    else if (command == "выход")
    {
        Console.WriteLine("Выход из программы...");
        break;
    }
    else
    {
        Console.WriteLine("Команда не распознана.");
    }
}

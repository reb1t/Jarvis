using System.Diagnostics;

while (true)
{
    Console.Write("Введите команду: ");
    string? command = Console.ReadLine()?.ToLower();
    if (command == "открой steam")
    {
        Process.Start("C:\\Program Files (x86)\\Steam\\steam.exe");
        Console.WriteLine("Steam открыт!");
    }
    else if (command == "открой zen")
    {
        Process.Start("C:\\Program Files\\Zen Browser\\zen.exe");
        Console.WriteLine("Zen Browser открыт!");
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

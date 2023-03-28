using ChallengeApp;

Console.WriteLine("Witamy w Programie do oceny Pracowników");
Console.WriteLine("==========================================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika (znak q lub Q aby wyjść): ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    else if (input == "Q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Średnia:{statistics.Average}");
Console.WriteLine($"Minimum:{statistics.Min}");
Console.WriteLine($"Maksimum:{statistics.Max}");
Console.WriteLine($"Średnia ocena literowa: {statistics.AverageLetter}");

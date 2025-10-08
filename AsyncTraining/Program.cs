using System.Diagnostics;

namespace AsyncTraining;

class Program
{
    static async Task Main(string[] args)
    {
        Stopwatch stopwatch = new();
        stopwatch.Start();
        ProcessData("Файл 1");
        ProcessData("Файл 2");
        ProcessData("Файл 3");
        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed);
        
        stopwatch.Restart();
        stopwatch.Start();
        var task1 = ProcessDataAsync("Файл 11");
        var task2 = ProcessDataAsync("Файл 22");
        var task3 = ProcessDataAsync("Файл 33");
        await Task.WhenAll(task1, task2, task3);
        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed);
    }

    static void ProcessData(string dataName)
    {
        Thread.Sleep(3000);
        Console.WriteLine($"Обработка {dataName} завершена за 3 секунды");
    }

    static async Task ProcessDataAsync(string dataName)
    {
        await Task.Delay(3000);
        Console.WriteLine($"Обработка {dataName} завершена за 3 секунды");
    }
}
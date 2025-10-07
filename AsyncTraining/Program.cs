namespace AsyncTraining;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine(ProcessData("Файл 1"));
        Console.WriteLine(ProcessData("Файл 2"));
        Console.WriteLine(ProcessData("Файл 3"));
        
        Console.WriteLine(await ProcessDataAsync("Файл 11"));
        Console.WriteLine(await ProcessDataAsync("Файл 22"));
        Console.WriteLine(await ProcessDataAsync("Файл 33"));
    }

    static string ProcessData(string dataName)
    {
        Thread.Sleep(3000);
        return $"Обработка {dataName} завершена за 3 секунды";
    }

    static async Task<string> ProcessDataAsync(string dataName)
    {
        await Task.Delay(3000);
        return $"Обработка {dataName} завершена за 3 секунды";
    }
}
using Services;
using Entities;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var service = new Service();
        var beginTime = DateTime.Now;

        var itenList = await service.GetMarketData("https://apiv2.bdolytics.com/en/NA/market/central-market-data");

        foreach (var iten in itenList)
        {
            Console.WriteLine(iten.ToString());
        }

        var time = (DateTime.Now - beginTime).TotalSeconds;
        Console.WriteLine($"{time}s");
    }
}
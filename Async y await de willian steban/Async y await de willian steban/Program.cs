// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class DataDownloader
{
    private static readonly HttpClient client = new HttpClient();

    public async Task<string> DownloadDataAsync(string url)
    {
        Console.WriteLine("Iniciando la descarga de datos...");
        // Simula un retraso de 3 segundos para representar la descarga de datos
        await Task.Delay(3000);

      

        // Simulación del resultado
        string result = "Datos descargados de " + url;
        Console.WriteLine("Datos descargados.");
        return result;
    }
}
public class Program
{
    public static async Task Main(string[] args)
    {
        DataDownloader downloader = new DataDownloader();

        string url = "https://ejemplo.com/api/data";
        string data = await downloader.DownloadDataAsync(url);

        Console.WriteLine("Datos recibidos:");
        Console.WriteLine(data);
    }
}



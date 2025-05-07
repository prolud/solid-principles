using System;
using System.Runtime.CompilerServices;

namespace _1_SingleResponsability.CorrectAplication;

public static class SingleResponsabilityCorrect
{
    public static void DownloadFile()
    {
        var file = GetFileFromWeb();
        file.DownloadFile("/destination");

        Console.WriteLine("File downloaded successfully!");
    }

    private static ExcelFile GetFileFromWeb()
    {
        Console.WriteLine("Request made successfully!");
        return new ExcelFile();
    }
}

public class ExcelFile
{
    public void DownloadFile(string destination)
    {
        Console.WriteLine($"File saved successfully in {destination}!");
    }
}

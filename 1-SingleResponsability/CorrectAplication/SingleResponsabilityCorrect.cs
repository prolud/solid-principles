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

    internal static ExcelFile GetFileFromWeb()
    {
        Console.WriteLine("Request made successfully!");
        return new ExcelFile();
    }
}

internal class ExcelFile
{
    public void DownloadFile(string destination)
    {
        Console.WriteLine($"File saved successfully in {destination}!");
    }
}

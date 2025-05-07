using System;
using _1_SingleResponsability.CorrectAplication;

namespace _1_SingleResponsability.Violation;

public class SingleResponsabilityViolation
{
    public void DownloadFile()
    {
        // downloading file
        var file = new ExcelFile();
        file.DownloadFile(destination: "/");

        // saving file
        File.Copy("/", "/destination");

        Console.WriteLine("File downloaded successfully!");
    }
}

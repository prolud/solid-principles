namespace _2_OpenClosed.Violation;

public static class OpenClosedViolation
{
    public static void CalculateManyThings(int sum1, int sum2, int multiplie1, int multiplie2, int sub1, int sub2)
    {
        Console.WriteLine(sum1 + sum2);
        Console.WriteLine(multiplie1 * multiplie2);
        Console.WriteLine(sub1 - sub2);
    }
}
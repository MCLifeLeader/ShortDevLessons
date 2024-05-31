using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // Value with decimal precision
        double myDbl = 45.654345;

        // Convert double to int
        int myInt = (int)myDbl;

        // Precision preserved
        Console.WriteLine($"myDbl = {myDbl}");
        // Precision lost
        Console.WriteLine($"myInt = {myInt}");

        // Precision preserved
        Console.WriteLine($"myInt + myDbl = {myInt + myDbl}");
        Console.WriteLine($"myDbl + myInt = {myDbl + myInt}");

        // Convert int to string
        string myStr = Convert.ToString(15);
        Console.WriteLine($"Number to String = {myStr}");

        // Convert string to bytes
        byte[] myBytes = Encoding.UTF8.GetBytes(myStr);
        Console.WriteLine($"myBytes = {string.Join(", ", myBytes)}");

        // Convert string to chars
        char[] myChars = Encoding.UTF8.GetChars(myBytes);
        Console.WriteLine($"myChars = {string.Join(", ", myChars)}");
    }
}
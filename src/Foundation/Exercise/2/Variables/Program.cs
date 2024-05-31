internal class Program
{
    private static void Main(string[] args)
    {
        int myInt = 1;
        float myFloat = 1f;
        bool myBoolean = true;
        string myName = "John";
        char myChar = 'a';
        byte myByte = 0x20;
        double myDouble = 1.75;

        Console.WriteLine($"myInt = {myInt}");
        Console.WriteLine($"myFloat = {myFloat}");
        Console.WriteLine($"myBoolean = {myBoolean}");
        Console.WriteLine($"myName = {myName}");
        Console.WriteLine($"myChar = {myChar}");
        Console.WriteLine($"myDouble = {myDouble}");

        var x = 1;
        var y = 2;
        var sum = x + y;    // sum will also be defined as an integer

        Console.WriteLine($"sum = {sum}");

        var carType = CarType.Toyota;

        Console.WriteLine($"carType = {carType}");
    }

    public enum CarType
    {
        Toyota = 1,
        Honda = 2,
        Ford = 3,
    }
}

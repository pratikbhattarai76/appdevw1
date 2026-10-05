class Program
{
    static void Main()
    {
        byte myByte = 100;
        short myShort = 1000;
        int myInt = 42;
        long myLong = 100000L;
        float myFloat = 3.14f;
        double myDouble = 3.14159;
        decimal myDecimal = 99.99m;
        char myChar = 'A';
        bool myBool = true;

        string intAsString = myInt.ToString();

        string numberText = "3.14";
        double stringAsDouble = Convert.ToDouble(numberText);

        Console.WriteLine($"byte: {myByte}");
        Console.WriteLine($"short: {myShort}");
        Console.WriteLine($"int: {myInt}");
        Console.WriteLine($"long: {myLong}");
        Console.WriteLine($"float: {myFloat}");
        Console.WriteLine($"double: {myDouble}");
        Console.WriteLine($"decimal: {myDecimal}");
        Console.WriteLine($"char: {myChar}");
        Console.WriteLine($"bool: {myBool}");
        Console.WriteLine($"string (converted from int): {intAsString}");
        Console.WriteLine($"double (converted from string): {stringAsDouble}");
    }
}
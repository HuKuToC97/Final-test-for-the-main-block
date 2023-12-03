using static WorkWithString;



internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine(File.ReadAllText(@"HelloUser.md"));
        
        string[] startArray = CreateArrayString();
        PrintArrayString(startArray);

    }
}
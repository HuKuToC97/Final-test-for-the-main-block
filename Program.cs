using static WorkWithString;
using static AdditionalMethods;




internal class Program
{
    private static void Main(string[] args)
    {
        PrintAboutProgram(File.ReadAllText(@"HelloUser.md"));

        string[] startArray = CreateArrayString();
        Console.Clear();
        PrintArrayString(startArray);

        string[] modificateArray = ModificateArray(startArray);
        Console.Clear();
        PrintArrayString(startArray, "Ваш исходный массив: ");
        PrintArrayString(modificateArray, "Ваш модифицированный массив: ");


    }
}
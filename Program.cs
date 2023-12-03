using static WorkWithString;
using static AdditionalMethods;




internal class Program
{
    private static void Main(string[] args)
    {
        PrintAboutProgram(File.ReadAllText(@"HelloUser.md"));

        string[] startArray = CreateArrayString();
        PrintArrayString(startArray);

    }
}
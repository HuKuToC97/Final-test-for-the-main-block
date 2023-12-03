public class AdditionalMethods
{
    public static void PrintAboutProgram(string textFromFile)
    {
        System.Console.Clear();
        System.Console.WriteLine(textFromFile);
        System.Console.Write("Для продолжения нажмите любую клавишу: ");
        System.Console.ReadKey();
        System.Console.Clear();
    }
}
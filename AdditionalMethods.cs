
public class AdditionalMethods
{
    public static void PrintAboutProgram(string textFromFile)
    {
        System.Console.Clear();
        System.Console.WriteLine(textFromFile);
        PressToContinue();
        System.Console.Clear();
    }

    public static void ReadConsoleAndCheckForInt(string messageForUser, ref int numberReturn)
    {
        System.Console.Write(messageForUser);
        string stringFromConsole = System.Console.ReadLine();
        if (int.TryParse(stringFromConsole, out int numberFromStringForCheck)
            && numberFromStringForCheck > 0)
            numberReturn = numberFromStringForCheck;

        else{
            Console.WriteLine("Вы ввели некорректные данные, попробуйте еще раз");
            ReadConsoleAndCheckForInt(messageForUser, ref numberReturn);
        }

    }

    public static void PressToContinue()
    {
        System.Console.Write("Для продолжения нажмите любую клавишу: ");
        System.Console.ReadKey();
    }

}
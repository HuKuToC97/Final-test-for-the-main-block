

public class WorkWithString
{
    public static string[] CreateArrayString(string messageAboutArraySizeRequest = "Введите количество элементов массива строк (целое положительное число): ")
    {
        System.Console.Write(messageAboutArraySizeRequest);
        int arraySize = Convert.ToInt32(System.Console.ReadLine());
        string[] startArray = new string[arraySize];
        for (int i = 0; i < startArray.Length; i++)
        {
            System.Console.Write($"Введите элемент массива строк под номером {i+1} и нажмите Enter: ");
            startArray[i] = System.Console.ReadLine();
        }
        return startArray;
    }

    public static void PrintArrayString(string[] stringArray)
    {
        System.Console.WriteLine("Ваш массив: ");
        for (int i = 0; i < stringArray.Length; i++)
        {
            System.Console.Write($"\"{stringArray[i]}\" ");
        }
        System.Console.WriteLine();
    }
}

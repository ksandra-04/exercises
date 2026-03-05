namespace Shared;

public static class ConsoleExtension
{
    public static int GetInt(string message)
    {
        int number;
        bool isValid;

        do
        {
            Console.Write(message);
            isValid = int.TryParse(Console.ReadLine(), out number);
        }
        while (!isValid);

        return number;
    }
}

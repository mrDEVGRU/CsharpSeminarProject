public static class Library
{
    public static int GetNumber(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static string GetResult(int n)
    {
        string result = String.Empty;
        int index = 1;

        while (index <= n)
        {
            int sqr = index * index * index;
            result = result + "[" + index + "->" + sqr + "] ";
            index++;
        }
        return result;
    }
}
class Program
{
    /// <summary>
    /// this method checks whether inputed text is palindrome or not
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    static bool IsPalindrome(string text)
    {
        text = text.Replace(" ", "").ToLower();

        int left = 0;
        int right = text.Length - 1;
        while (left < right)
        {
            if (text[left] != text[right])
                return false;

            left++;
            right--;
        }
        return true;

    }
    static void Main(string[] args)
    {
        Console.Write("Input a string:  ");
        string text = Console.ReadLine();
        if (text == "")
        {
            Console.WriteLine("Please, enter a string and do not leave it empty.");
        }
        else
        {
            bool isPalidrone = IsPalindrome(text);
            Console.WriteLine(isPalidrone);
        }
    }
}
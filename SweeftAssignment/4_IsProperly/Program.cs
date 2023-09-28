class Program
{
    /// <summary>
    /// this method determines if sequence is mathematically right.
    /// </summary>
    /// <param name="sequence"></param>
    /// <returns></returns>
    static bool IsProperly(string sequence)
    {
        sequence = sequence.Replace(" ", "").ToLower();

        int left = 0;
        int right = sequence.Length - 1;
        while (left <= right)
        {
            if (sequence[left] == sequence[right])
                return false;

            left++;
            right--;
        }
        return true;
    }
    static void Main(string[] args)
    {
        Console.Write("Input Sequence of '(' and ')': ");
        string sequence = Console.ReadLine();
        bool prop = IsProperly(sequence);
        Console.WriteLine(prop);
    }
}
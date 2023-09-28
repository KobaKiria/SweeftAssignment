class Program
{
    /// <summary>
    /// it counts minimum quantity of coins that can be used to split the inputed amount.
    /// </summary>
    /// <param name="amount"></param>
    /// <returns></returns>
    static int MinSplit(int amount)
    {
        int[] coins = { 50, 20, 10, 5, 1 };
        int minSplit = 0;
        foreach (int coin in coins)
        {
            while (amount >= coin)
            {
                amount -= coin;
                minSplit++;
            }
        }
        return minSplit;
    }
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int minSplit = MinSplit(amount);
            Console.WriteLine($"Minimum {minSplit} monets can be used");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please, enter only numbers");
        }
    }
}
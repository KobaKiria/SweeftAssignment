class Program
{
    /// <summary>
    /// it counts how many possible ways exist for going up on stairs.
    /// </summary>
    /// <param name="stairCount"></param>
    /// <returns></returns>
    static int CountVariants(int stairCount)
    {
        
        if (stairCount <= 1)
        {
            return 1;
        }
        else if (stairCount == 2)
        {
            return 2;
        }
        else
        {
            int[] ways = new int[stairCount + 1];
            ways[0] = 1;
            ways[1] = 1;

            for (int i = 2; i <= stairCount; i++)
            {
                ways[i] = ways[i - 1] + ways[i - 2];
            }

            return ways[stairCount];
        }
        
    }
    static void Main(string[] args)
    {
        try
        {
            Console.Write("enter quantity of steps:  ");
            int stairCount = Convert.ToInt32(Console.ReadLine());

            int ways = CountVariants(stairCount);
            Console.WriteLine("quantity of variants: " + ways);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please, enter only numbers." + ex.Message);
        }
    }
}
/*class Program
{

    static int NotContains(int[] array)
    {
        int minNumber = int.MaxValue;

        foreach(int number in array)
        {
            if (number>0 && number < minNumber) 
                minNumber = number;
                    
        }
        return minNumber;
        
    }
    static void Main(string[] args)
    {
        int[] array = { -7, 0, 8, 6, 44, -9 };
        int minNumber = NotContains(array);
        Console.WriteLine(minNumber);
    }
}*/
using System;

class Program
{

    static int NotContains(int[] array)
    {
        
       int minPosNumber = 1;
       while(array.Contains(minPosNumber))
        {
            minPosNumber++;
        }
        return minPosNumber;
    }
    static void Main()
    {
        int[] array = { -7, 0, 8, 1, 44, -9,  2 };
        int minPosNumber = NotContains(array);
        Console.WriteLine("The minimum positive number which is not in Array is " + minPosNumber);

    }
}

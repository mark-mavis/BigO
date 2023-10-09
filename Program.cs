using System.Threading;
using System;

namespace BigO;

class Program
{
    public static bool JumpingNumber(int num)
    {
        string numStr = Convert.ToString(num);
        if (numStr.Length == 1) return true;
        for (int numStr_It = 1; numStr_It < numStr.Length; numStr_It++)
        {
            int previous = Convert.ToInt32(numStr[numStr_It - 1]);
            int current = Convert.ToInt32(numStr[numStr_It]);
            if (Math.Abs(previous - current) != 1) return false;
        }

        return true;
    }

    public static void JumpingNumberController(int num, bool printResults)
    {
        for (int i = 1; i <= num; i++)
        {
            if (JumpingNumber(i))
            {
                if (printResults)
                {
                    Console.Write(i + " ");
                }
            }
        }
        if (printResults) Console.WriteLine();

    }

    public static void JumpingNumberAnalysis(int num, bool printResults)
    {

        for (int i = 1; i < num; i++)
        {
            JumpingNumberController(i, printResults);
        }
    }
    public static void Main()
    {

        //JumpingNumberController(100, true);
        JumpingNumberAnalysis(100, true);

    }
}


using System.Diagnostics;

namespace SortingAlgorithms;
public abstract class SortAlgo{
    public string? name;
    protected int[]? localArr;
    public HashSet<long> testResults = new HashSet<long>();
    public void Run(int[] arr){
        localArr = new int[arr.Length];
        Array.Copy(arr, localArr, arr.Length);

        Stopwatch stopWatch = Stopwatch.StartNew();
        stopWatch.Start();
        Implementation(localArr);     
        stopWatch.Stop();
        Console.WriteLine($"{name}: {stopWatch.ElapsedTicks}");
    }

    protected abstract void Implementation(int[] sourceArray);
}
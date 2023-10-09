
using System.Diagnostics;
namespace SortingAlgorithms;

public class SelectionSort : SortAlgo{
    public SelectionSort() {
        name = "Selection Sort";
    }
    protected override void Implementation(int[] arr){
        int n = arr.Length;
        // 0 - Holds Value
        // 1 = Holds idx
        Stopwatch stopWatch = Stopwatch.StartNew();
        stopWatch.Start();
        for(int i = 0; i < n-1; i++){
            int minIdx = i;
            for(int j = i+1; j < n; j++){
                if(arr[j] < arr[minIdx]){
                    minIdx = j;
                } 
            }
            int temp = arr[i];
            arr[i] = arr[minIdx];
            arr[minIdx] = temp;
        }
        stopWatch.Stop();
        testResults.Add(stopWatch.ElapsedTicks);
    }
}
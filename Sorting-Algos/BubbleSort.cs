namespace SortingAlgorithms;

public class BubbleSort : SortAlgo{
    public BubbleSort(){
        name="Bubble Sort";
    }
    protected override void Implementation(int[] arr){
        
        int? n = localArr?.Length;
        for(int i = 0; i < n-1; i++){
            int swapCount = 0;
            for(int j = 1; j < n; j++){
                if(arr[j-1] > arr[j]) {
                    (arr[j-1], arr[j]) = (arr[j], arr[j-1]);
                    swapCount++;
                }
            }
            if(swapCount == 0) break;
        }
        
    }
}
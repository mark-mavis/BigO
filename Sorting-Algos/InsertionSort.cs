namespace SortingAlgorithms;

public class InsertionSort : SortAlgo{
    public InsertionSort(){
        name="Insertion Sort";
    }
    protected override void Implementation(int[] arr){
        int? n = localArr?.Length;
        for(int j = 1; j < n; j++){
            int key = arr[j];
            int i = j-1;
            while(i >= 0 && arr[i] > key){
                arr[i+1] = arr[i];
                i--;
                arr[i+1] = key;
            }
        }
    }
}
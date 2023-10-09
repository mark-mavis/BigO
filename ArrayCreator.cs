public class ArrayCreator{
    public static int[] Create(int arraySize, int minVal, int maxVal){
        int[] newArray = new int[arraySize];
        Random rnd = new Random();
        for(int i = 0; i < newArray.Length; i++){
            newArray[i] = rnd.Next(minVal, maxVal);
        }
        return newArray;
    }
}
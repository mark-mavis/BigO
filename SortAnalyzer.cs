using SortingAlgorithms;

public class SortAnalyzer{
    protected int[]? arr;
    protected HashSet<SortAlgo> sortAlgos;
    
    public SortAnalyzer(){
        sortAlgos = new HashSet<SortAlgo>();
    }
    public void RunAnalysis(){
        if(arr != null){
            foreach(SortAlgo sAlgo in sortAlgos){
                sAlgo.Run(arr);
            }
        }
    }

    public void DisplayResults(){
        if(arr != null){
            foreach(SortAlgo sAlgo in sortAlgos){
                Console.WriteLine($"{sAlgo.name}:");
                Console.WriteLine(String.Join(',', sAlgo.testResults));
            }
        }
    }

    public void LoadAlgos(){
        //sortAlgos.Add(new BubbleSort());
        sortAlgos.Add(new SelectionSort());
        //sortAlgos.Add(new InsertionSort());
    }

    public void Push(SortAlgo sortAlgo){
        sortAlgos.Add(sortAlgo);
    }
    public void Remove(SortAlgo sortAlgo){
        sortAlgos.Remove(sortAlgo);
    }
    public void CreateArray(int arraySize, int minVal, int maxVal){
        arr = ArrayCreator.Create(arraySize, minVal, maxVal);
    }
}
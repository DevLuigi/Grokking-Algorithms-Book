using System.Diagnostics;

public class Program {

    public static void Main() {
        int[] array = {1, 2, 3, 4, 5, 6, 7, 8};

        var stopWatch = new Stopwatch();

        stopWatch.Start();
        Console.WriteLine(BinarySearch(array, 6));
        stopWatch.Stop();

        Console.WriteLine(stopWatch.Elapsed);        
    }
    public static int BinarySearch(int[] array, int item) {
        int low     = 0;
        int high    = array.Length - 1;
        int middle  = 0;
        int guess   = 0;

        while (low <= high) {
            middle  = (int)Math.Floor(((double)low + (double)high) / 2);
            guess   = array[middle];

            if(guess == item) {
                return middle;
            }  

            if (guess > item) {
                high = middle - 1;               
            } else {
                low  = middle + 1;
            }
        } 

        return -1;
    }
}
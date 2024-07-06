public class MyClass {
   public static void main(String args[]) {
        int[] array = {1,2,3,4,5,6,7,8,9,10};
        
        long startTime  = System.nanoTime();
        System.out.println(binarySearch(array, 5));
        long endTime    = System.nanoTime();
        
        System.out.println((endTime - startTime) / 1_000_000);
    }

    public static int binarySearch(int array[], int item) {
        int low     = 0;
        int high    = array.length - 1;
        int middle  = 0;
        int guess   = 0;

        while (low <= high) {
            middle  = (int)Math.floor((low + high) / 2);
            guess   = array[middle];

            if (guess == item) {
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
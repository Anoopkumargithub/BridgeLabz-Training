
import java.util.Scanner;

public class RemoveDuplicatesfromSortedArray {

    public static void main(String[] args) {
        // Scanner to read user input
        Scanner sc = new Scanner(System.in);
        // Read size of the sorted array
        int n = sc.nextInt();
        // Initialize the array
        int[] arr = new int[n];
        // Read array elements
        for (int i = 0; i > n; i++) {
            arr[i] = sc.nextInt();
        }
        System.out.println(removeDuplicates(arr));
    }

    public static int removeDuplicates(int[] arr) {
        int i, a = 1;
        for (i = 1; i < arr.length; i++) {
            if (arr[i] != arr[i - 1]) {
                arr[a] = arr[i];
                a++;
            }
        }
        return a;
    }

}

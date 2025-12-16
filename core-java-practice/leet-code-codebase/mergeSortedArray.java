
import java.util.Arrays;
import java.util.Scanner;

public class mergeSortedArray {

    public static void main(String[] args) {
        // Scanner for reading input
        Scanner sc = new Scanner(System.in);
        // Read array sizes
        int n1 = sc.nextInt();
        int n2 = sc.nextInt();

        int[] arr1 = new int[n1 + n2];
        int[] arr2 = new int[n2];
        // Read valid elements of arr1
        for (int i = 0; i < n1; i++) {
            arr1[i] = sc.nextInt();
        }
        // Read valid elements of arr2
        for (int i = 0; i < n2; i++) {
            arr2[i] = sc.nextInt();
        }

        int m = sc.nextInt();
        int n = sc.nextInt();
        // Merge arrays
        merge(arr1, m, arr2, n);
    }

    public static void merge(int[] arr1, int m, int[] arr2, int n) {
        int k = 0;
        for (int i = 0; i < m; i++) {
            arr1[k++] = arr1[i];
        }
        for (int i = 0; i < n; i++) {
            arr1[k++] = arr2[i];
        }
        Arrays.sort(arr1);
        for (int i = 0; i < arr1.length; i++) {
            System.out.print(arr1[i] + " ");
        }
    }

}

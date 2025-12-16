
import java.util.Arrays;
import java.util.Scanner;

public class removeElement {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        int[] arr = new int[n];
        for (int i = 0; i < n; i++) {
            arr[i] = sc.nextInt();
        }
        int val = sc.nextInt();

        int k = 0;
        Arrays.sort(arr);
        for (int i = 0; i < n; i++) {
            if (arr[i] != val) {
                k = arr[i];
                k++;
            }
        }
        System.out.println(k);
    }
}

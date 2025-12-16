
import java.util.Scanner;

public class twoSum {

    public static void main(String[] args) {
        //  Scanner for read input from the user
        Scanner sc = new Scanner(System.in);
        //  read size of an array
        int n = sc.nextInt();
        //  define the array
        int[] arr = new int[n];
        //  read array elements
        for (int i = 0; i < n; i++) {
            arr[i] = sc.nextInt();
        }
        //  read terget sum
        int tar = sc.nextInt();

        // find the indices of two no. that sum is euqal to target
        boolean flag = false;
        for (int i = 0; i < n && !flag; i++) {
            for (int j = i + 1; j < n; j++) {
                if (arr[i] + arr[j] == tar) {
                    System.out.println(i + " " + j);
                    flag = true;
                    break;
                }
            }
        }
    }
}

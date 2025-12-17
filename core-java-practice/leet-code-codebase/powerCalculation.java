
import java.util.Scanner;

public class powerCalculation {
    public static void main(String[] args) {
        //  Scanner for read input from the user
        Scanner sc = new Scanner(System.in);
        // read user input
        int n = sc.nextInt();
        int m = sc.nextInt();
        int pow = (int) Math.pow(n,m);
        System.out.println(pow);
    }
}

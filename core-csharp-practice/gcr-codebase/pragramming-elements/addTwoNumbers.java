
import java.util.Scanner;

public class addTwoNumbers {
    public static void main(String[] args) {
        //  Scanner for read input from the user
        Scanner sc = new Scanner(System.in);
        // take first number input
        int n = sc.nextInt();
        // take second number input
        int m = sc.nextInt();
        int sum = n+ m;
        System.out.println("Total is " + sum);
        sc.close();
    }
}

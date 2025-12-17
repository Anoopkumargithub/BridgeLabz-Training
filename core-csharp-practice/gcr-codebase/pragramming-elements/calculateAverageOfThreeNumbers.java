
import java.util.Scanner;

public class calculateAverageOfThreeNumbers {
    public static void main(String[] args) {
        //  Scanner for read input from the user
        Scanner sc = new Scanner(System.in);
        //  read user input
        int a = sc.nextInt();
        int b = sc.nextInt();
        int c = sc.nextInt();
        int avg = (int) (a+b+c)/3;
        System.out.println("Avg. of three numbers: " + avg);
    }
}

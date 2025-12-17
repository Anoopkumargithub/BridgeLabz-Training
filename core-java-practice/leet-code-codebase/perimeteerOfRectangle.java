
import java.util.Scanner;

public class perimeteerOfRectangle {
    public static void main(String[] args) {
        //  Scanner for read input from the user
        Scanner sc = new Scanner(System.in);
        // read user input
        int l = sc.nextInt();
        int b = sc.nextInt();
        int area = l*b;
        System.out.println("Area: "+ area);
    }
}

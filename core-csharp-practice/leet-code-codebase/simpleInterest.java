
import java.util.Scanner;

public class simpleInterest {
    public static void main(String[] args) {
        //  Scanner for read input from the user
        Scanner sc = new Scanner(System.in);
        //  read user input
        int p = sc.nextInt();
        int r = sc.nextInt();
        int t = sc.nextInt();
        double si = (p*r*t)/100;
        System.out.println("Simple Interset: "+ si);
    }
}

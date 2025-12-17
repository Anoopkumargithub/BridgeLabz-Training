
import java.util.Scanner;

public class convertKilometerToMiles {
    public static void main(String[] args) {
        //  Scanner for read input from the user
        Scanner sc = new Scanner(System.in);
        //  read user input
        int km = sc.nextInt();
        double miles = km * 0.621371;
        System.out.println(miles);
    }
}

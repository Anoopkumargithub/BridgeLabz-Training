
import java.util.Scanner;

public class celsiustoFahrenheit {
    public static void main(String[] args) {
        //  Scanner for read input from the user
        Scanner sc = new Scanner(System.in);
        // take temperature input
        int celsius =sc.nextInt();
        int fahrenheit = (celsius * (9/5)) + 32;
        System.out.println("Temperature in Fahrenheit: "+ fahrenheit);
        sc.close();
    }
}

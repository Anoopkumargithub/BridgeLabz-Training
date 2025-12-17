
import java.util.Scanner;

public class volumeOfCylinder {
    public static void main(String[] args) {
        //  Scanner for read input from the user
        Scanner sc = new Scanner(System.in);
        //  read radius and height input
        int radius = sc.nextInt();
        int height = sc.nextInt();
        double volume = Math.PI*Math.pow(radius, 2)*height;
        System.out.println("Volume of Cyclinder: "+ volume);
    }
}

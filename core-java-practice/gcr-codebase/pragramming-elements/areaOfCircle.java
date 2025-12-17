import java.util.Scanner;

public class areaOfCircle {
    public static void main(String[] args) {
        //  Scanner for read input from the user
        Scanner sc = new Scanner(System.in);
        //  input radius of a circle
        int radius = sc.nextInt();
        double area = Math.PI*radius*radius;
        System.out.println("Area of Circle: "+ area);
        sc.close();
    }
}

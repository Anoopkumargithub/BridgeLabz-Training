
import java.util.Scanner;

public class palindromeNumber {

    public static void main(String[] args) {
        //  Scanner for read input from the user
        Scanner sc = new Scanner(System.in);
        //  Read the no. of check
        int n = sc.nextInt();
        System.out.println(isPalindrome(n));
    }

    public static boolean isPalindrome(int x) {
        //  -ve no. are not plaindrome
        if (x < 0) {
            return false;
        }
        int rev = 0;
        int a = x;
        // reverse the no. 
        while (x > 0) {
            int rem = x % 10;
            rev = rev * 10 + rem;
            x /= 10;
        }
        return a == rev;
    }
}

import java.util.Scanner;


public class CountOfBitsOne {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input integer n: ");
        int n = input.nextInt();
        int count = 0;
       
        for (int i = 0; i < 32; i++) {
                if ((n&1)==1) {
                        count++;
                }
                n = n>>1;
        }
        System.out.println("Ones: " + count);
	}

}

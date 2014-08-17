import java.util.Scanner;


public class SumTwoNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int int1 = 0, int2 = 0;
		System.out.print("Input first integer: ");
		int1 = input.nextInt();
		System.out.print("Input second integer: ");
		int2 = input.nextInt();
		System.out.println("Sum: " + (int1 + int2));
	}

}

import java.util.Scanner;



public class SmallestOfThree {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input first number: ");
		double num1 = input.nextDouble();
		System.out.print("Input second number: ");
		double num2 = input.nextDouble();
		System.out.print("Input third number: ");
		double num3 = input.nextDouble();
		if(num1>num2)
			num1=num2;
		if(num1>num3)
			num1=num3;
		System.out.println("Smallest: " + num1);
	}
}
import java.util.Scanner;

public class FormattingNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input integer A: ");
		int a = input.nextInt();
		System.out.print("Input floating-point B: ");
		double b = input.nextDouble();
		System.out.print("Input floating-point C: ");
		double c = input.nextDouble();
		
		String outAHex = Integer.toHexString(a).toUpperCase();
		String outABin = Integer.toBinaryString(a).replace(' ', '0');
		
		if (1 == 0)
			System.out.printf("|%-10s|%s|%10.2f|%-10.0f|", outAHex, outABin, b, c);
		else
			System.out.printf("|%-10s|%s|%10.2f|%-10.3f|", outAHex, outABin, b, c);
	}
}

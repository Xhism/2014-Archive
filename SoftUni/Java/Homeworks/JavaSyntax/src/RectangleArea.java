import java.util.Scanner;


public class RectangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input side a: ");
		int a = input.nextInt();
		System.out.print("Input side b: ");
		int b = input.nextInt();
		System.out.println("Area = " + a*b);
	}

}

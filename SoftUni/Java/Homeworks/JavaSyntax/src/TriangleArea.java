import java.util.Scanner;


public class TriangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input point A coordinate X: ");
		int aX = input.nextInt();
		System.out.print("Input point A coordinate Y: ");
		int aY = input.nextInt();
		System.out.print("Input point B coordinate X: ");
		int bX = input.nextInt();
		System.out.print("Input point B coordinate Y: ");
		int bY = input.nextInt();
		System.out.print("Input point C coordinate X: ");
		int cX = input.nextInt();
		System.out.print("Input point C coordinate Y: ");
		int cY = input.nextInt();
		
		double area = Math.abs((aX*(bY-cY)+bX*(cY-aY)+cX*(aY-bY))/2);
		System.out.println("Area = " + area);
	}

}

import java.util.Scanner;


public class PointsInFigure {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input coordinate X: ");
		double x = input.nextDouble();
		System.out.print("Input coordinate Y: ");
		double y = input.nextDouble();
		boolean xCheck = false;
		boolean yCheck = false;
		boolean middleHoleCheck = true;
		
		if(x>=12.5 && x<=22.5)
			xCheck = true;
		if(y>=6 && y<=13.5)
			yCheck = true;
		if(x>17.5 && x<20 && y>8.5)
			middleHoleCheck = false;
		if(xCheck && yCheck && middleHoleCheck)
			System.out.println("Inside");
		else
			System.out.println("Outside");
	}

}

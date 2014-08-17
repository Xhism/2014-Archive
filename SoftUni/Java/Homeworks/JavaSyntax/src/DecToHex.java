import java.util.Scanner;


public class DecToHex {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input decimal integer: ");
		int num = input.nextInt();
		int remainder;
		String hex = "";
		
		while(num>0)
		{
			remainder = num%16;
			if(remainder < 10)
				hex = remainder + hex;
			else if(remainder == 10)
				hex = "A" + hex;
			else if(remainder == 11)
				hex = "B" + hex;
			else if(remainder == 12)
				hex = "C" + hex;
			else if(remainder == 13)
				hex = "D" + hex;
			else if(remainder == 14)
				hex = "E" + hex;
			else if(remainder == 15)
				hex = "F" + hex;
			num/=16;
		}
		System.out.print("Hexadecimal: " + hex);
	}

}

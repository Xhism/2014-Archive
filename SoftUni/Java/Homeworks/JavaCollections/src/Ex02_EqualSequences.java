import java.util.Scanner;


public class Ex02_EqualSequences {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Input any amount of words on one line:");
		String str = input.nextLine();
		String[] arr = str.split(" ");
		
		System.out.print(arr[0]);
		for (int i = 1; i < arr.length; i++) {
			if (arr[i].equals(arr[i - 1])) {
				System.out.print(" " + arr[i]);
			} else {
				System.out.println();
				System.out.print(arr[i]);
			}
		}
	}
}

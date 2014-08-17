import java.util.Scanner;

public class Ex05_WordCount {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Input a line of words:");
		String str = input.nextLine();
		String[] words = str.split("\\W+");
		System.out.println(words.length);
	}
}

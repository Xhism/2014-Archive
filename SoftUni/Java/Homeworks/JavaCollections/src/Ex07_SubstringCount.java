import java.util.Scanner;


public class Ex07_SubstringCount {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		System.out.println("Input a line of words:");
		String sentence = in.nextLine().toLowerCase();
		System.out.print("Input substring to be counted: ");
		String word = in.nextLine().toLowerCase();
		int counter = 0;

		for (int i = 0; i <= sentence.length() - word.length(); i++) {
			if (sentence.substring(0 + i, word.length() + i).contains(word)) {
				counter++;
			}
		}
		System.out.println(counter);
	}
}

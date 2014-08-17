import java.util.Arrays;
import java.util.Scanner;


public class Ex01_SortArray {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input amount of numbers: ");
		int n = input.nextInt();
		int[] arr = new int[n];
		for(int i = 0; i < n; i++)
		{
			System.out.print("Input number " + (i+1) + ": ");
			arr[i]=input.nextInt();
		}
		Arrays.sort(arr);
		System.out.print("Sorted: ");
		for(int i = 0; i < n; i++)
		{
			System.out.print(arr[i] + " ");
		}
	}
}

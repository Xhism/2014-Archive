import java.util.Scanner;


public class CountBitsPairs {
	public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Input integer n: ");
        int n = input.nextInt();
		int bit = 0;
		int count = 0;
		int pairs = 0;
		
		while(n > 0) {
		   if ((n & 1) == 1 && bit == 0) {
		        count = 0;
		        bit = 1;
		    }
		
		    if ((n & 1) == 0 && bit == 1) {
		        count = 0;
		        bit = 0;
		    }
		
		    if ((n & 1) == 1) {
		        bit = 1;
		    }
		    else {
		        bit = 0;
		    }
		
		    if ((n & 1) == 1 && bit == 1) {
		        count++;
		        if (count == 2) {
		            pairs++;
		            count = 1;
		        }
		    }
		
		    if ((n & 1) == 0 && bit == 0) {
		        count++;
		        if (count == 2) {
		            pairs++;
		            count = 1;
		        }
		    }
		
		    n = n >> 1;
		}
		System.out.println("Bit pairs: " + pairs);
	}
}

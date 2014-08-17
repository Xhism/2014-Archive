using System;


class BitArrayTest
{
    static void Main()
    {
        int testNum = 8765;
        Console.WriteLine("Printing the test number bit by bit:");
        Console.WriteLine(Convert.ToString(testNum, 2).PadLeft(64, '0'));

        ulong number = (ulong)testNum;
        BitArray64 bits = new BitArray64(number);

        Console.WriteLine("\nPrinting the bit array cell by cell:");
        foreach (var bit in bits)
        {
            Console.Write(bit);
        }
        Console.WriteLine();

        BitArray64 bits2 = new BitArray64((ulong)8766);

        Console.WriteLine("\nTesting: Equals with overridden method:");
        Console.WriteLine(bits.Equals(bits2));
        Console.WriteLine("Regular equals:");
        Console.WriteLine(bits == bits2);
        Console.WriteLine("\nChecking whether it is NOT equal:");
        Console.WriteLine(bits != bits2);

        Console.WriteLine(bits);
        Console.WriteLine("\nTesting: Operator [] by showing the digit at position [0]:");
        Console.WriteLine(bits[0]);
    }
}


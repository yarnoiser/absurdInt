using System;
using System.Collections.Generic;

public class AbsurdIntTest{
	public static void Main(){
		System.Console.WriteLine("Constructor: No Args");
		AbsurdInt test = new AbsurdInt();
		System.Console.WriteLine(test);
		System.Console.WriteLine("Constructor: Int Arg");
		AbsurdInt test2 = new AbsurdInt(10);
		System.Console.WriteLine(test2);
		System.Console.WriteLine("Constructor: Iterable");
		AbsurdInt test3 = new AbsurdInt(new UInt64[] {512, 1});
		System.Console.WriteLine(test3);
		System.Console.WriteLine("GetDigitMax: (expect 18446744073709551615)");
                System.Console.WriteLine(test3.GetDigitMax());
		System.Console.WriteLine("ToULong: (expect 512)");
		System.Console.WriteLine(test3.ToULong());
		System.Console.WriteLine("GetDigits: (expect \"512 1\")");
		foreach(var digit in test3.GetDigits()){
			System.Console.Write(digit);
			System.Console.Write(" ");
		}
		System.Console.WriteLine("");
		System.Console.WriteLine("EqualTo: Expect false");
		System.Console.WriteLine(test3.EqualTo(test));
		System.Console.WriteLine("EqualTo: Expect true");
		AbsurdInt test4 = new AbsurdInt(new UInt64[] {512, 1});
		System.Console.WriteLine(test3.EqualTo(test4));
	}
}


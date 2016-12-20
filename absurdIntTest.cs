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
		
		System.Console.WriteLine("DigitMax: (expect 18446744073709551615)");
                System.Console.WriteLine(AbsurdInt.DigitMax());
		
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

                System.Console.WriteLine("EqualTo: Expect false");
		AbsurdInt test5 = new AbsurdInt(new UInt64[] {100, 23, 9, 7, 4});
		System.Console.WriteLine(test5.EqualTo(test4));
		
		System.Console.WriteLine("EqualTo: Expect true");
		AbsurdInt test6 = new AbsurdInt(new UInt64[] {100, 23, 9, 7, 4});
		System.Console.WriteLine(test5.EqualTo(test6));

		System.Console.WriteLine("LessThan: Expect false");
		System.Console.WriteLine(test6.LessThan(test4));

		System.Console.WriteLine("LessThan: Expect false");
		System.Console.WriteLine(test6.LessThan(test5));

		System.Console.WriteLine("LessThan: Expect true");
		System.Console.WriteLine(test4.LessThan(test6));

		System.Console.WriteLine("GreaterThan: Expect false");
		System.Console.WriteLine(test4.GreaterThan(test6));

		System.Console.WriteLine("GreaterThan: Expect false");
		System.Console.WriteLine(test5.GreaterThan(test6));

		System.Console.WriteLine("GreaterThan: Expect true");
		System.Console.WriteLine(test5.GreaterThan(test4));

		System.Console.WriteLine("LessThanOrEqualTo: Expect false");
		System.Console.WriteLine(test5.LessThanOrEqualTo(test4));

		System.Console.WriteLine("LessThanOrEqualTo: Expect true");
		System.Console.WriteLine(test5.LessThanOrEqualTo(test6));

		System.Console.WriteLine("LessThanOrEqualTo: Expect true");
		System.Console.WriteLine(test4.LessThanOrEqualTo(test5));

		System.Console.WriteLine("GreaterThanOrEqualTo: Expect false");
		System.Console.WriteLine(test4.GreaterThanOrEqualTo(test5));

		System.Console.WriteLine("GreaterThanOrEqualTo: Expect true");
		System.Console.WriteLine(test5.GreaterThanOrEqualTo(test4));

		System.Console.WriteLine("GreaterThanOrEqualTo Expect true");
		System.Console.WriteLine(test5.GreaterThanOrEqualTo(test6));

		System.Console.WriteLine("ToString: Expect 100, 23, 9, 7, 4");
		System.Console.WriteLine(test6.ToString());

	}
}


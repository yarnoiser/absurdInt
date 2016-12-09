using System;
using System.Collections.Generic;

public class AbsurdInt{
	private List<UInt64> digits;

	public AbsurdInt(){
		digits = new List<UInt64>();
	}

	public AbsurdInt(UInt64 num){
		digits = new List<UInt64> ();
		digits.Add (num);
	}

	public UInt64 ToULong(){
		UInt64 result = 0;
		foreach (var digit in digits) {
			if (result == 0) {
				result = digit;
			} else {
				result *= digit;
			}
		}
		return result;
	}

	public UInt64 Base(){
		return UInt64.MaxValue;
	}
}


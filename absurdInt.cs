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

	public AbsurdInt(IEnumerable<UInt64> digits){
		this.digits = new List<UInt64>(digits);
	}

	public UInt64 ToULong(){
		return digits [0];
	}

	public UInt64 GetDigitMax(){
		return UInt64.MaxValue;
	}

	public List<UInt64> GetDigits(){
		return new List<UInt64> (digits);
	}

	public bool EqualTo(AbsurdInt comp){
		if (digits.Count != comp.digits.Count) {
			return false;
		}
		for (int i = 0; i < digits.Count; i++) {
			if (digits [i] != comp.digits [i]) {
				return false;
			}
		}
		return true;
	}

	public bool LessThan(AbsurdInt comp){
		if (digits.Count < comp.digits.Count) {
			return true;
		}
		if (digits.Count > comp.digits.Count) {
			return false;
		}
		for (int i = digits.Count - 1; i >= 0; i--) {
			if (digits [i] < comp.digits [i]) {
				return true;
			}
		}
		return false;
	}

	public bool GreaterThan(AbsurdInt comp){
		if (this.LessThan (comp)) {
			return false;
		}
		if (this.EqualTo (comp)) {
			return false;
		}
		return true;
	}
}


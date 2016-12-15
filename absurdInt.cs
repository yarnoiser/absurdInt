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

	public static UInt64 GetDigitMax(){
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

	public bool LessThanOrEqualTo(AbsurdInt comp){
		return this.LessThan(comp) || this.EqualTo(comp);
	}

	public bool GreaterThanOrEqualTo(AbsurdInt comp){
		return this.GreaterThan(comp) || this.EqualTo(comp);
	}

	public AbsurdInt Copy(){
		return AbsurdInt(digits);
	}

	private bool KeepAdding(AbsurdInt val, int index){
		if (index >= digits.Count){
			return false;
		}

		if (index >= val.digits.Count){
			return false;
		}

		return true;
	}

	private bool AddDigits(AbsurdInt, val, bool overflow, int index){
		UInt64 toOverflow = AbsurdInt.DigitMax() - digits[i];
		bool newOverflow = false;

		if(overflow){
			if(1 > toOverflow){
				digits[i] = 0;
				newOverflow = true;
			} else{
				digits[i] ++;
			}
		}

		toOverflow = AbsurdInt.DigitMax() - digits[i];
		if (val.digits[i] > toOverflow){
			digits[i] = val.digits[i] - toOverflow;
			newOverflow = true;
		} else{
			digits[i] += val.digits[i];
		}

		return newOverflow;
	}
}


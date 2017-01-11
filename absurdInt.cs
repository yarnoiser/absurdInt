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

	public static UInt64 DigitMax(){
		return UInt64.MaxValue;
	}

	public override string ToString(){
		string result = "";
		for(int i = 0; i < digits.Count; i++){
			result += digits[i].ToString();
			if (i != digits.Count - 1){
				result += ", ";
			}
		}
		return result;
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
		return new AbsurdInt(digits);
	}

	private static Tuple<UInt64, bool> AddDigits(UInt64 digit1, UInt64 digit2, bool overflow){
		bool newOverflow = false;
		UInt64 toOverflow = AbsurdInt.DigitMax() - digit1;
		UInt64 result;

		if (digit2 > toOverflow){
			newOverflow = true;
			result = digit2 - toOverflow - 1;
		} else{
			result = digit1 + digit2;
		}

		toOverflow = AbsurdInt.DigitMax() - result;

		if (overflow){
			if (toOverflow < 1){
				newOverflow = true;
				result = 0;
			} else{
				result ++;
			}
		}
		return Tuple.Create(result, newOverflow);
	}

	public AbsurdInt Add(AbsurdInt val){
		AbsurdInt result = new AbsurdInt();
		bool overflow = false;
		for(int i = 0; i < digits.Count; i++){
			if (i >= val.digits.Count){
				if (overflow){
					result.digits.Add(1);
				}
				break;
			}
			Tuple<UInt64, bool> digit = AddDigits(digits[i], val.digits[i], overflow);
			result.digits.Add(digit.Item1);
			overflow = digit.Item2;
		}
		if (overflow){
			result.digits.Add(1);
		}
		return result;
	}

	public AbsurdInt Add(UInt64 val){
		return this.Add(new AbsurdInt(val));
	}

	private static Tuple<UInt64, bool> SubDigits(Uint64 digit1, Uint64 digit2, bool underflow){
		bool newUnderflow = false;
		if (underflow){
			if (digit1 > 0){
				digit1 -= 1;
			} else{
				digit1 = AbsurdInt.DigitMax();a
				newUnderflow = true;
			}
		}
		if (digit1 >= digit2){
			return Tuple.Create(digit1 - digit2, newUnderflow);
		} else{
			return Tuple.Create(AbsurdInt.DigitMax() - digit2 + digit1, true);
		}
	}


}


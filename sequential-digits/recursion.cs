// not sure how but got "Runtime 0ms, Beats 100.00%"


public class Solution {
	public IList<int> SequentialDigits(int low, int high) {
        int seqNum = 1;
        List<int> answer = [];

		void AddAllSequentialDigitsInFixedLength(int n) {
            if (n >= low & n <= high) {
                answer.Add(n);
            }

			if (n % 10 != 9 && n <= high) {
                n = AddNextDigitToSequentialNumber(n);
                n = RemoveFirstDigitOfNumber(n);
				AddAllSequentialDigitsInFixedLength(n);
			}
		}
		
        while (seqNum <= high) {
            AddAllSequentialDigitsInFixedLength(seqNum);
            
            seqNum = AddNextDigitToSequentialNumber(seqNum);
        }

        return answer;
    }

    public static int AddNextDigitToSequentialNumber(int seqNum) {
        return (seqNum * 10) + ((seqNum % 10) + 1);
    }
	
	public static int RemoveFirstDigitOfNumber(int num) {
		int divisor = (int)Math.Pow(10, (int)Math.Log10(num));
		return num % divisor;
	}
}

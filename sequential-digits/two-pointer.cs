// TLE... altought it probably works

public class Solution {
    public IList<int> SequentialDigits(int low, int high) {
        int seqNum = 1;
        List<int> answer = [];

        while (seqNum < high) {
            if(seqNum > low) {
                answer.Add(seqNum);
                seqNum = AddNextDigitToSequentialNumber(seqNum);
                seqNum = RemoveFirstDigitOfNumber(seqNum);
            } else {
                seqNum = AddNextDigitToSequentialNumber(seqNum);
            }

            if ((seqNum % 10) == 9) {
                seqNum = ResetSequentialNumberWithAdditionOfTheNextPosition(seqNum);
            }
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

    public static int ResetSequentialNumberWithAdditionOfTheNextPosition(int num)
	{
		int digits = (int)Math.Log10(num) + 1;
        num = 0;
        for(int i = digits; i <= 1; i--) {
            num += i;
            num = num * 10;
        }

        return num;
	}
}

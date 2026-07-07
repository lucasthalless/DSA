public class Solution {
    public long SumAndMultiply(int n) {
        long numberWithoutZeros = 0, positionMultiplier = 1, sum = 0;

        while (n != 0) {
            numberWithoutZeros = (n % 10) * positionMultiplier + numberWithoutZeros;
            if (n % 10 != 0) positionMultiplier = positionMultiplier * 10;
            sum += n % 10;
            n = n / 10;
        }

        return sum * numberWithoutZeros;
    }
}

public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        int[] sortedArray = (int[])arr.Clone();
        Array.Sort(sortedArray);

        Dictionary<int, int> valueToRank = new Dictionary<int, int>();
        int currentRank = 1;    

        foreach (int value in sortedArray)
        {
            if (!valueToRank.ContainsKey(value))
            {
                valueToRank[value] = currentRank++;
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = valueToRank[arr[i]];
        }

        return arr;
    }
}

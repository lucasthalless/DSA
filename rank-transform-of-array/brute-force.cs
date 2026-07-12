public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        List<int> sortedArr = arr.OrderBy(x => x).Distinct().ToList();
        List<int> ranks = [];

        for(int i = 0; i < arr.Length; i++) {
            ranks.Add(sortedArr.IndexOf(arr[i]) + 1);
        }

        return ranks.ToArray();
    }
}

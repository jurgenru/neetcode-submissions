public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> kDict = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (kDict.ContainsKey(num)) {
                kDict[num] += 1;
            } else {
                kDict.Add(num, 1);
            }
        }
        int[] kArr = kDict.OrderByDescending(x => x.Value).Select(x => x.Key).ToArray();
        return kArr[0..k];
    }
}

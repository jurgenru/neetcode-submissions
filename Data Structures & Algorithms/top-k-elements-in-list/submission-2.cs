public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> kDict = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (kDict.ContainsKey(num))
            {
                kDict[num] += 1;
            }
            else
            {
                kDict.Add(num, 1);
            }
        }
        int[][] kArr = new int[nums.Length + 1][];
        for (int i = 0; i < kArr.Length; i++)
        {
            kArr[i] = [];
        }
        foreach (var (key, value) in kDict)
        {
            kArr[value] = kArr[value].Append(key).ToArray();
        }
        int[] kRes = [];
        for (int j = kArr.Length - 1; j > 0; j--)
        {
            if (kRes.Length == k) return kRes;
            if (kArr[j].Length > 0)
            {
                if (kArr[j].Length + kRes.Length <= k)
                {
                    kRes = [.. kRes, .. kArr[j]];
                }
                else
                {
                    int biggerBy = kRes.Length - k;
                    return [.. kRes, .. kArr[j][0..biggerBy]];

                }
            }
        }
        return kRes;
    }
}
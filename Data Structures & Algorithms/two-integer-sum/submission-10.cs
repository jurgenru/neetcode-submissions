public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> sumDict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            int toSearch = target - nums[i];
            if(!sumDict.ContainsKey(toSearch)){
                sumDict.Add(nums[i], i);
            } else {
                return [sumDict[toSearch], i];
            }
        }
        return [];
    }
}

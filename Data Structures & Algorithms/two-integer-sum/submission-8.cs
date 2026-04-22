public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> sumDict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(!sumDict.ContainsKey(target - nums[i])){
                sumDict.Add(nums[i], i);
            } else {
                if(i < sumDict[target - nums[i]]) return [i, sumDict[target - nums[i]]];
                return [sumDict[target - nums[i]], i];
            }
        }
        return [];
    }
}

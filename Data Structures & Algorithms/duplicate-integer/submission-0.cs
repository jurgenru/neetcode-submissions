public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> num = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            if(num.Contains(nums[i])) return true;
            num.Add(nums[i]);
        }
        return false;
    }
}
// Two-Sum [Easy]

/*
    Problem Definition:

        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        You can return the answer in any order.

        Example 1:

        Input: nums = [2,7,11,15], target = 9
        Output: [0,1]
        Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
        Example 2:

        Input: nums = [3,2,4], target = 6
        Output: [1,2]
        Example 3:

        Input: nums = [3,3], target = 6
        Output: [0,1]
        
        Constraints:

        2 <= nums.length <= 104
        -109 <= nums[i] <= 109
        -109 <= target <= 109
        Only one valid answer exists.

*/

// ******************************************** //

public class Solution01 {
    public int[] TwoSum(int[] nums, int target) {
        int num_size = nums.Length;
        int diff;
        for(int i=0; i<num_size; i++){
            diff = target - nums[i];
            for(int j=i+1; j<num_size; j++){
                if (nums[j] == diff){
                    return new int[2] {i, j};
                }
            }
        }
        return null;
    }
}

public class Solution02 {
    public int[] TwoSum(int[] nums, int target) {
        int i, value, num_size = nums.Length;
        Dictionary<int,int> samples = new Dictionary<int,int>();
        for(i=0; i<num_size; i++){
            if (samples.TryGetValue(target-nums[i], out value))
            {
                return new int[2] {i, value};
            }
            samples[nums[i]] = i;
        }
        return null;
    }
}

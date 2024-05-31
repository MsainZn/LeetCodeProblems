/**
    Problem Definition:
        Given a string s, find the length of the longest 
        substring
        without repeating characters.

        Example 1:

        Input: s = "abcabcbb"
        Output: 3
        Explanation: The answer is "abc", with the length of 3.
        Example 2:

        Input: s = "bbbbb"
        Output: 1
        Explanation: The answer is "b", with the length of 1.
        Example 3:

        Input: s = "pwwkew"
        Output: 3
        Explanation: The answer is "wke", with the length of 3.
        Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
        
        Constraints:

        0 <= s.length <= 5 * 104
        s consists of English letters, digits, symbols and spaces.
 */

public class Solution01 {
    public int LengthOfLongestSubstring(string s) {
        // Variables to store and evaluate sub-problems
        var local_set = new HashSet <string>(); 
        int strLen = s.Length;       
        int max_len = 0;
        
        // Evaluation Loop
        for (int i=0; i<strLen-max_len; i++){
            // Iterate until finding similar or end @ max!
            for (int j=i; j<strLen; j++){
                // Add to set if not exists
                if (!local_set.Add(s.Substring(j, 1))){ 
                    break;
                }
            }
            max_len = (max_len > local_set.Count) ? max_len : local_set.Count;
            local_set.Clear();
        }
        return max_len;
    }

// Using Sliding Window helps you to obtain O(n) 
public class Solution02 {
    public int LengthOfLongestSubstring(string s) {
        // Variable to store and evaluate sub-problems
        var local_set = new HashSet <int>(); 
        // Sliding Window     
        int start = 0, end = 0, MaxLen=0;
        int strLen = s.Length;  
        while (end < strLen){
            if (local_set.Add(s[end])){ 
                end++;
                MaxLen = Math.Max(MaxLen, local_set.Count);
            } else{
                local_set.Remove(s[start]);
                start++;
            }
        }
        return MaxLen;
    }
}



}
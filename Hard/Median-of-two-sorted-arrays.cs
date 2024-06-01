/*
    Problem Description:

        Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

        The overall run time complexity should be O(log (m+n)).

        Example 1:

        Input: nums1 = [1,3], nums2 = [2]
        Output: 2.00000
        Explanation: merged array = [1,2,3] and median is 2.
        Example 2:

        Input: nums1 = [1,2], nums2 = [3,4]
        Output: 2.50000
        Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

        Constraints:

        nums1.length == m
        nums2.length == n
        0 <= m <= 1000
        0 <= n <= 1000
        1 <= m + n <= 2000
        -106 <= nums1[i], nums2[i] <= 106
*/

public class Solution01 {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        int size1 = nums1.Length, size2 = nums2.Length;
        int sum_size = size1 + size2;
        var arr = new int [sum_size]; 

        int i=0, j=0, k=0;
        
        while (i < size1 && j < size2){
            if(nums1[i] >= nums2[j]){
                arr[k++] = nums2[j++];
            } else{
                arr[k++] = nums1[i++];
            }
        }

        while (i < size1){
            arr[k++] = nums1[i++];
        }

        while (j < size2){
            arr[k++] = nums2[j++];
        }

        return (k%2==0) ? 0.5 * (arr[k/2] + arr[k/2-1]) : arr[k/2];
    }
}
/**
    Problem Definition:
        You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. 
        Add the two numbers and return the sum as a linked list.
        You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        Input: l1 = [2,4,3], l2 = [5,6,4]
        Output: [7,0,8]
        Explanation: 342 + 465 = 807.
        Example 2:

        Input: l1 = [0], l2 = [0]
        Output: [0]
        Example 3:

        Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
        Output: [8,9,9,9,0,0,0,1]

        Constraints:

        The number of nodes in each linked list is in the range [1, 100].
        0 <= Node.val <= 9
        It is guaranteed that the list represents a number that does not have leading zeros.
 */


// Auxilary Predefined Definitions
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution01 {

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int nval=0) {
        
        if (l1 == null && l2 == null && nval == 0) return null;
        int sum = (l1!=null ? l1.val:0) + (l2!=null ? l2.val:0) + nval;
        return new ListNode(sum%10, AddTwoNumbers(l1?.next, l2?.next, sum/10));
    }
}

public class Solution02 {

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        ListNode lsumRoot = new ListNode(0, null);

        ListNode iter = lsumRoot;
        int summ, nval=0;
        while (iter!= null){
            summ = 0;
            if (l1 != null){
                summ += l1.val;
                l1 = l1.next;
            }
            if (l2 != null){
                summ += l2.val;
                l2 = l2.next;
            }
            summ += nval;
            iter.val = summ%10;
            nval = summ/10;
            
            if (l1 == null && l2 == null && nval == 0) {
                break;
            }
            iter.next = new ListNode(nval, null);
            iter = iter.next;
            
        }
        return lsumRoot;

    }
}

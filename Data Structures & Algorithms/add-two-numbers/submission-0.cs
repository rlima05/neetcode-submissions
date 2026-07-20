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

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = new ListNode(0);
        int carry = 0;
        var dummy = head;

        while(l1 != null || l2 != null || carry != 0)
        {   
            int sum = carry;

            if(l1 != null)
            {
                sum+= l1.val;
                l1 = l1.next;
            }
            if(l2 != null)
            {
                sum+= l2.val;
                l2 = l2.next;
            }

            carry = sum/10;
            dummy.next = new ListNode(sum%10);
            dummy = dummy.next;
        }


        return head.next;
    }
}

/*
loop through the lists while both of them have values
    case 1: both have values
        sum l1+l2 + rem
    case 2: l1 is null
        sum = l2 + rem
    case 3: l2 is null
        sum = l1+rem

    set remainingValue = sum%10
    sum /=10

    newList val = sum

once loop is finished check if there is any rem to add as a last node

*/
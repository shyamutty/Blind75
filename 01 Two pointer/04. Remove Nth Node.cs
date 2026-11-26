/*

https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/
*/

//Structure:
public ListNode RemoveNthFromEnd(ListNode head, int n)
{
    // Create a dummy node

    // Initialize slow and fast pointers

    // Move fast pointer n steps ahead

    // Move both pointers until fast reaches the end

    // Remove the target node

    // Return the updated head
}
---------------------
//Code:

  public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        // Create dummy node
        ListNode dummy = new ListNode(0);
        dummy.Next = head;

        // Initialize pointers
        ListNode slow = dummy;
        ListNode fast = dummy;

        // Move fast n steps ahead
        for (int i = 0; i < n; i++)
        {
            fast = fast.Next;
        }

        // Move both pointers until fast reaches the last node
        while (fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next;
        }

        // Remove the target node
        slow.Next = slow.Next.Next;

        return dummy.Next;
    }
}


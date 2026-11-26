/*
Linked List Cycle
https://leetcode.com/problems/linked-list-cycle/description/
*/

//Structure:
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        // Initialize slow and fast pointers

        while (/* condition */)
        {
            // Move slow by one step

            // Move fast by two steps

            // Check if slow and fast meet
            if (/* condition */)
            {
                return true;
            }
        }

        return false;
    }
}

------------

//Code:

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;           // Move 1 step
            fast = fast.Next.Next;      // Move 2 steps

            if (slow == fast)
            {
                return true;
            }
        }

        return false;
    }
}


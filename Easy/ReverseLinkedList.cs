using AuxiliaryClasses;

namespace Easy;

public class ReverseLinkedList
{
    public static ListNode? Solve(ListNode? head)
    {
        // First, we begin by traversing the linked list
        // using a list<listNode> to get the references set in order.
        List<ListNode> dp = new();
        while (head != null)
        {
            dp.Add(head);
            head = head.next;
        }

        // Then, traverse back the linked list from the end to the beginning
        ListNode? newHead = dp.LastOrDefault();

        if (newHead == null)
        {
            return null;
        }

        ListNode? headPtr = newHead;

        for (int i = dp.Count - 1; i >= 0; i--)
        {
            if (i > 0)
            {
                // And change "next" pointers and return the reference to the first node.
                newHead.next = dp[i - 1];
                newHead = dp[i - 1];
            }
            else
            {
                newHead.next = null;
            }
        }

        return headPtr;
    }
}
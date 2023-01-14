using AuxiliaryClasses;

namespace Easy;

public class HasCycle
{
    public bool Solve(ListNode? head)
    {
        bool result = false;
        List<ListNode> dp = new();

        while (head != null)
        {
            // It uses Object.Equals for object comparison, meaning it compares pointers and not values.
            if (dp.Contains(head))
            {
                result = true;
                break;
            }

            dp.Add(head);
            head = head.next;
        }

        return result;
    }
}
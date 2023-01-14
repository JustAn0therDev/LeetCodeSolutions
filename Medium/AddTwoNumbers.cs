using System.Numerics;
using AuxiliaryClasses;

namespace Medium;

public class AddTwoNumbers
{
    public ListNode Solve(ListNode l1, ListNode l2)
    {
        // sum the two linked lists (know that they are both reversed.)
        // return the sum as a reversed linked list.

        List<int> l1Items = new();
        List<int> l2Items = new();

        while (l1 != null)
        {
            l1Items.Add(l1.val);
            l1 = l1.next;
        }

        while (l2 != null)
        {
            l2Items.Add(l2.val);
            l2 = l2.next;
        }

        l1Items.Reverse();
        l2Items.Reverse();

        BigInteger firstNumber = BigInteger.Parse(string.Join("", l1Items));
        BigInteger secondNumber = BigInteger.Parse(string.Join("", l2Items));

        // For some reason, JetBrains Rider complains about 
        // doing operations with BigInteger types although
        // the type does implement all math operations...
        BigInteger result = firstNumber + secondNumber;

        List<BigInteger> listResultDigits = new();

        while (result > 0)
        {
            listResultDigits.Add(result % 10);
            result /= 10;
        }

        return ConvertToLinkedList(listResultDigits);
    }

    public static ListNode ConvertToLinkedList(List<BigInteger> list)
    {
        ListNode listNode = new();
        ListNode pointerToFirstNode = listNode;
        ListNode lastNode = null;

        for (int i = 0; i < list.Count; i++)
        {
            listNode.val = (int)list[i];

            if (lastNode != null)
            {
                lastNode.next = listNode;
            }

            lastNode = listNode;
            listNode = new();
        }

        return pointerToFirstNode;
    }
}
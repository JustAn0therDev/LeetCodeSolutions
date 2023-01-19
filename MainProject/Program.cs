using AuxiliaryClasses;
using Easy;

ListNode? list = null;

list = ReverseLinkedList.Solve(list);

while (list != null)
{
    Console.WriteLine(list.val);
    list = list.next;
}

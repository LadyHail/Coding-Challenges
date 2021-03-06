/*
 DESCRIPTION:
 Given a singly linked list of integers l and an integer k, remove all elements from list l that have a value equal to k.
 Example
    For l = [3, 1, 2, 3, 4, 5] and k = 3, the output should be
    removeKFromList(l, k) = [1, 2, 4, 5];
    For l = [1, 2, 3, 4, 5, 6, 7] and k = 10, the output should be
    removeKFromList(l, k) = [1, 2, 3, 4, 5, 6, 7].
*/


namespace Main.CodeFights
{
    // Definition for singly-linked list:
    public class ListNode<T>
    {
        public T value { get; set; }
        public ListNode<T> next { get; set; }
    }

    public static class RemoveKFromList
    {
        public static ListNode<int> Solve(ListNode<int> l, int k)
        {
            if (l == null)
            {
                return null;
            }

            if (l.value == k)
            {
                return Solve(l.next, k);
            }

            l.next = Solve(l.next, k);
            return l;
        }
    }
}

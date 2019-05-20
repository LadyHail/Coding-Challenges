/*
 DESCRIPTION: 
 Given a singly linked list of integers, determine whether or not it's a palindrome.

 Note: in examples below and tests preview linked lists are presented as arrays just 
 for simplicity of visualization: in real data you will be given a head node l of the linked list

 Example:

    For l = [0, 1, 0], the output should be
    isListPalindrome(l) = true;

    For l = [1, 2, 2, 3], the output should be
    isListPalindrome(l) = false.
*/

using System.Collections.Generic;

namespace Main.CodeFights
{
    public class IsListPalindrome
    {
        public static bool Solve(ListNode<int> l)
        {
            ListNode<int> current = l;
            ListNode<int> fastStep = l;
            Stack<int> stack = new Stack<int>();

            while (fastStep != null && fastStep.next != null)
            {
                stack.Push(current.value);
                current = current.next;
                fastStep = fastStep.next.next;
            }

            if (fastStep != null)
            {
                current = current.next;
            }

            while (current != null)
            {
                if (stack.Pop() != current.value)
                {
                    return false;
                }
                current = current.next;
            }

            return true;
        }
    }
}

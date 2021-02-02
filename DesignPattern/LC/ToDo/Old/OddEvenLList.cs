namespace CSharp.OLD
{
    class OddEvenLList1
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
                return null;

            if (head.next == null)
                return head;

            var h1 = head;
            var p1 = head; // tracks index 1 3 5 7 ..
            var p2 = head.next; // tracks index 2 4 6 8 ..
            var p2Start = head.next;

            if (p2Start.next == null) // if only 2 node return as it is
                return head;

            while (p2?.next != null)
            {
                p1.next = p1.next.next; // index 1's next is now 3 // index 3's next is now 5 and so on
                p2.next = p2.next.next;// index 2's next is now 4// index 4's next is now 6 and so on
                p1 = p1.next; // update p1 (which is pointing to 1) index to 3 and so on
                p2 = p2.next; // update p1 (which is pointing to 2) index to 4 and so on
            }

            p1.next = p2Start; // update p1 next to be start of 2 4 6 link list // so LL become 1 -> 3 -> 5 -> 2 -> 4
            return h1;
        }
    }
}

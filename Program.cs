public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
             this.val = val;
             this.next = next;
         }
 }

public class Program
{
    public static ListNode MergeKLists(ListNode[] lists)
    {

        if (lists.Length < 1)
            return null;
        
        ListNode aux = lists[0];
        for (int i = 1; i < lists.Length; i++)
            aux = mergeTwoLists(aux,lists[i]);
        return aux;
    }

    public static ListNode mergeTwoLists(ListNode l1Head, ListNode l2Head)
    {
        if (l1Head == null)
        {
            if (l2Head == null)
                return null;
            return l2Head;
        }

        if (l2Head == null)
        {
            if (l1Head == null)
                return null;
            return l1Head;
        }

        ListNode i = l1Head;
        ListNode j = l2Head;
        
        ListNode l3 = new ListNode();
        ListNode l3Head = l3;
        
        while (i != null && j != null) {
            if (i.val <= j.val)
            {
                l3.val = i.val;
                i = i.next;
            }
            else
            {
                l3.val = j.val;
                j = j.next;
            }

            if (i == null || j == null)
                break;
            l3.next = new ListNode();
            l3 = l3.next;
        }

        while (i != null)
        {
            l3.next = new ListNode(i.val);
            i = i.next;
            l3 = l3.next;
        }
        
        while (j != null)
        {
            l3.next = new ListNode(j.val);
            j = j.next;
            l3 = l3.next;
        }
        return l3Head;
    }
    
    public static void printList(ListNode node)
    {
        while (node != null)
        {
            node = node.next;
        }
    }
    
    public static void Main(String[] Args)
    {
        ListNode l1 = new ListNode(1);
        ListNode l2 = new ListNode(2);
        l1.next = l2;
        
        ListNode l3 = new ListNode(3);
        l2.next = l3;
        
        
        ListNode U1 = new ListNode(4);
        ListNode U2 = new ListNode(5);
        U1.next = U2;
        
        ListNode U3 = new ListNode(6);
        U2.next = U3;
        ListNode U4 = new ListNode(7);
        U3.next = U4;
        
        //eeeee
        ListNode J1 = new ListNode(0);
        ListNode J2 = new ListNode(2);
        J1.next = J2;
        
        ListNode J3 = new ListNode(3);
        J2.next = J3;
        ListNode J4 = new ListNode(5);
        J3.next = J4;

        ListNode[] listNode={l1,U1};

        ListNode resultNode = MergeKLists(listNode);
        Console.WriteLine("\n\n\n\n");
    }
}
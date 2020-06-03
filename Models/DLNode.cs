namespace LinkedList.Models
{
    public class DLNode
    {
        public int Value;
        public DLNode Next;

        public DLNode Prev;
        // public int Count;
        public DLNode(int val)
        {
            Value = val;
            Next = null;
            Prev = null;
            // Count = 0;
        }

    }
}
//void pop void pushtail size
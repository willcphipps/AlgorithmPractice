namespace LinkedList.Models
{
    public class SLNode
    {
        public int Value;
        public SLNode Next;
        public SLL Child;
        public bool isTail;
        public int Count;
        public SLNode(int val)
        {
            Value = val;
            Next = null;
            Child = null;
            isTail = false;
            Count = 0;
        }

    }
}
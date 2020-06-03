namespace CSharpAlgo.Models
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
        public Node(int val)
        {
            Value = val;
        }
    }
}
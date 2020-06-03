using System;

namespace LinkedList.Models
{
    public class SLL
    {
        public SLNode Head;
        public int Count;
        public SLL()
        {
            Head = null;
            Count = 0;
        }

        public void Print()
        {
            int printCount = 0;
            var runner = Head;
            while(runner != null)
            {
                printCount += 1;
                Console.Write($"{runner.Value}, ");
                runner = runner.Next;
                if(printCount > Count ){
                    Console.WriteLine("no infinite loops!");
                    break;
                }
            }
            Console.WriteLine("");
        }

        public SLL AddBack(int val)
        {
            SLNode node = new SLNode(val);
            if(Head == null)
            {
                Head = node;
                Count += 1;
            }
            else
            {
                var runner = Head;
                while(runner.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = node;
                Count += 1;
            }
            return this;
        }

        public SLL AddChild(SLL list, int val)
        {
            var runner = Head;
            while(runner.Next != null)
            {
                if(runner.Value == val)
                {
                    runner.Child = list;
                    return this;
                }
                runner = runner.Next;
            }
            return this;
        }
        

        public SLL FlattenChildren()
        {
            var runner = Head;
            while(runner != null)
            {
                if(runner.Child == null)
                {
                    runner = runner.Next;
                    continue;
                }
                else
                {
                    var temp = runner.Next;
                    runner.Next = runner.Child.Head;
                    var childRunner = runner.Child.Head;
                    while(childRunner.Next != null)
                    {
                        childRunner = childRunner.Next;
                    }
                    childRunner.isTail = true;
                    childRunner.Next = temp;
                    runner = temp;
                }
            }
            return this;
        }


        public SLL UnflattenChildren()
        {
            var runner = Head;

            while (runner != null)
            {
                if(runner.Child != null)
                {
                    var temp = runner.Child.Head;
                    var childRunner  = runner.Child.Head;
                    while(!childRunner.isTail)
                    {
                        childRunner = childRunner.Next;
                    }
                    runner.Next = childRunner.Next;
                    childRunner.Next = null;
                }
                runner = runner.Next;
            }
            return this;
        }
    }
}
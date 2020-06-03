namespace CSharpAlgo.Models
{
    using System;
    using System.Collections.Generic;

    public class BST
    {
        public Node Root { get; set; }
        private int _count { get; set; } = 0;
        private int _height { get; set; }
        // private int _measure { get; set; }
        public int Height{
            get{
                _Height(Root, 0);
                return _height;
            }
        }
        // private void _Ballance(Node root, int measureR, int measureL){
        //     if(root == null){

        //     }
        // }
        private void _Height(Node Squirrel, int levels){
            if(Squirrel == null){
                if(levels > _height){
                    _height = levels;
                }
            }
            else{
                _Height(Squirrel.Left, levels + 1);
                _Height(Squirrel.Right, levels + 1);
            }
        }
        public int Size{
            get {
                Helper(Root);
                return _count; 
                }
        }
        private void Helper(Node squirrel){
            if(squirrel != null){
                _count++;
                Helper(squirrel.Left);
                Helper(squirrel.Right);
            }
        }
        public bool Contains(int val, Node squirrel)
        {
            if (squirrel == null){
                return false;
            }
            else
            {
                Console.WriteLine(squirrel.Value);
                if (squirrel.Value == val)
                {
                    return true;
                }
                else if (squirrel.Value > val)
                {
                    return Contains(val, squirrel.Left);
                }
                else if(squirrel.Value < val)
                {
                    return Contains(val, squirrel.Right);
                }
            }
            return false;
        }
        public void Insert(int val)
        {
            Node Squirrel = null;
            if (Root == null)
            {
                Root = new Node(val);
            }
            else
            {
                Squirrel = Root;
                while (Squirrel != null)
                {
                    if (Squirrel.Value >= val)
                    {
                        if (Squirrel.Left == null)
                        {
                            Squirrel.Left = new Node(val);
                            break;
                        }
                        else
                        {
                            Squirrel = Squirrel.Left;
                        }
                    }
                    else
                    {
                        if (Squirrel.Right == null)
                        {
                            Squirrel.Right = new Node(val);
                            break;
                        }
                        else
                        {
                            Squirrel = Squirrel.Right;
                        }
                    }
                }
            }
        }

        public void Print()
        {
            Node Squirrel = null;
            if (Root == null)
            {
                Console.WriteLine("No Tree Here");
            }
            else
            {
                Squirrel = Root;
                Console.WriteLine("tree exists");

            }

        }

        public void PrintValues()
        {
            PrintValues(Root);
        }

        public void PrintValues(Node squirrel)
        {
            if (squirrel != null)
            {
                System.Console.WriteLine(squirrel.Value);
                PrintValues(squirrel.Left);
                PrintValues(squirrel.Right);
            }
        }
    }
}

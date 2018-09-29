using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Paderov Evgeny
/// </summary>
namespace GU_Algorithms
{

    class Program
    {
        // 6 урок
        static void Main(string[] args)
        {
            #region 1. Реализовать простейшую хеш-функцию. На вход функции подается строка, на выходе сумма кодов символов.
            Console.WriteLine(GetHash("skdnfksjdbfkjhs bgkjwejlfbkjsf"));
            Console.WriteLine(GetHash("skdnfksjdbfkjhs bgkvwejlfbkjsfknfkbdfgkhdfgjkdkfjgkdfgkjhdfgbdkfgkjdfnnnnnnngkdfgjdfghdfkgk"));
            Console.WriteLine(GetHash("skdnfksjdbfkjhs bgkvwejlfbkjsfknfkbdfgkhdfgjkdkfjgkdfgkjhdfgbdkfgkjdfnnnnnnngkdfgjdfghdfkgk"));
            Console.WriteLine();
            #endregion

            #region 2. Переписать программу, реализующую двоичное дерево поиска.

            int[] arr = new int[] { 10, 7, 9, 12, 6, 14, 11, 3, 4, };

            BinaryTree bt = new BinaryTree();
            foreach (int i in arr)
            {
                bt.Add(i);
            }
            // а) Добавить в него обход дерева различными способами;
            bt.Print();

            Console.WriteLine();

            // б) Реализовать поиск в двоичном дереве поиска;
            Console.WriteLine(bt.Find(12));
            Console.WriteLine(bt.Find(13));
            Console.WriteLine(bt.Find(3));
            #endregion
            Console.ReadKey();
        }

        // 1. Реализовать простейшую хеш-функцию. На вход функции подается строка, на выходе сумма кодов символов.
        static long GetHash(string arg)
        {
            long hash = -1;
            foreach (int c in arg)
                hash += c % 100 * arg.Length;

            return hash;
        }




    }
    // 2. Переписать программу, реализующую двоичное дерево поиска.
    class BinaryTree
    {
        private int length = 0;
        private Node root;

        public int Length { get => length; }

        public void Add(int val)
        {
            if (Length == 0)
            {
                root = new Node(val);
                root.Id = 0;
                length = 1;
                return;
            }
            if (Length > 0)
            {
                AddToNode(val, root);

            }

        }

        // а) Добавить в него обход дерева различными способами;
        // Обход КЛП (не вижу смысла реализовывать остальные, так как там только строчки надо местами переставить)
        public void Print()
        {
            Console.WriteLine("root " + root.Value);
            Print(root);
        }
        private void Print(Node n)
        {
            if (n.Left != null)
            {
                Console.WriteLine("left " + n.Left + " Parent " + n.Value);
                Print(n.Left);
            }
            if (n.Right != null)
            {
                Console.WriteLine("right " + n.Right + " Parent " + n.Value);
                Print(n.Right);
            }
        }

        // б) Реализовать поиск в двоичном дереве поиска;
        public Node Find(int val)
        {
            if (root == null) return null;
            if (root.Value == val) return root;
            return Find(val, root);
        }
        private Node Find(int val, Node n)
        {
            if (n.Value == val) return n;
            if (n.Left != null)
            {
                var t = Find(val, n.Left);
                if (t != null) return t;
            };
            if (n.Right != null)
            {
                var t = Find(val, n.Right);
                if (t != null) return t;
            };
            return null;
        }

        private void AddToNode(int val, Node n)
        {
            if (n.Value < val && n.Right == null)
            {
                n.Right = new Node(val, null, null, n);
                n.Right.Id = length;
                length++;
                return;
            }
            else if (n.Value > val && n.Left == null)
            {
                n.Left = new Node(val, null, null, n);
                n.Left.Id = length;
                length++;
                return;
            }

            if (n.Value < val)
                AddToNode(val, n.Right);
            else
                AddToNode(val, n.Left);
        }

        internal BinaryTree()
        {
            length = 0;
            root = null;
        }
    }

    class Node
    {
        int value;
        Node right;
        Node left;
        Node parent;
        int id;

        internal Node(int value, Node right, Node left, Node parent) : this(value)
        {
            this.right = right;
            this.left = left;
            this.parent = parent;
        }
        internal Node(int value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"ID: {id} Value: {value}";
        }

        public int Value { get => value; set => this.value = value; }
        internal Node Right { get => right; set => right = value; }
        internal Node Left { get => left; set => left = value; }
        internal Node Parent { get => parent; set => parent = value; }
        public int Id { get => id; set => id = value; }
    }
}


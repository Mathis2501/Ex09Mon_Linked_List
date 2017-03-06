using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTNS
{
    public class BST
    {
        private Node Root;
        public int count { get; private set; }

        public void Insert(IComparable data)
        {
            Node N = Root;
            bool running = true;
            if (Root == null)
            {
                Root = new Node();
                Root.Data = data;
                count = 1;
            }
            else
            {
                while (running)
                {
                    if (data.CompareTo(Root.Data) < 0)
                    {
                        if (N.LeftNode == null)
                        {
                            N.LeftNode = new Node();
                            running = false;
                            N.LeftNode.Data = data;
                            count++;
                        }
                        else
                        {
                            N = N.LeftNode;
                        }
                    }
                    if (data.CompareTo(N.Data) > 0)
                    {
                        if (N.RightNode == null)
                        {
                            N.RightNode = new Node();
                            running = false;
                            N.RightNode.Data = data;
                            count++;
                        }
                        else
                        {
                            N = N.RightNode;
                        }
                    }
                }
            }
        }

        public void PrintTree()
        {
            Console.WriteLine(Root.Data.ToString());
            Console.WriteLine(Root.LeftNode.Data.ToString());
            Console.WriteLine(Root.LeftNode.LeftNode.Data.ToString());
            Console.WriteLine(Root.LeftNode.RightNode.Data.ToString());
            Console.WriteLine(Root.RightNode.Data.ToString());
        }
    }
}

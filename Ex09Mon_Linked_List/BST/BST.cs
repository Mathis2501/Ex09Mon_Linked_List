using System;
using System.Collections.Generic;
using System.Data;
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
            
            if (Root == null)
            {
                Root = new Node();
                Root.Data = data;
                count = 1;
            }
            else
            {
                Node N = Root;
                while (N != null)
                {
                    if (data.CompareTo(N.Data) < 0)
                    {
                        if (N.LeftNode == null)
                        {
                            N.LeftNode = new Node();
                            N.LeftNode.Data = data;
                            count++;
                            break;
                        }
                        N = N.LeftNode;
                    }
                    if (data.CompareTo(N.Data) > 0)
                    {
                        if (N.RightNode == null)
                        {
                            N.RightNode = new Node();
                            N.RightNode.Data = data;
                            count++;
                            break;
                        }
                        N = N.RightNode;
                    }
                    if (data.CompareTo(N.Data) == 0)
                    {
                        throw new DuplicateNameException("Duplicate NR.");
                    }
                }
            }
        }

        public bool Search(IComparable data)
        {
            Node N = Root;
            if (Root == null)
            {
                Root = new Node();
                Root.Data = data;
                count = 1;
            }
            else
            {
                while (N != null)
                {
                    if (data.CompareTo(Root.Data) < 0)
                    {
                        if (N.LeftNode == null)
                        {
                            N = N.LeftNode;
                        }
                    }
                    if (data.CompareTo(N.Data) > 0)
                    {
                        if (N.RightNode == null)
                        {
                            N = N.RightNode;
                        }
                    }
                    if (data.CompareTo(N.Data) == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void PrintTree()
        {
            Root.PrintData();
        }
    }
}

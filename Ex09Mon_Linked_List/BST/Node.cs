using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTNS
{
    public class Node
    {
        public Node RightNode;
        public Node LeftNode;
        public object Data;


        public void PrintData()
        {
            RightNode?.PrintData();
            Console.WriteLine(Data.ToString());
            LeftNode?.PrintData();
        }
    }
}

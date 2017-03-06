using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src
{
    public class MyList
    {
        private Node head;
        public int count { get; private set; }

        public void Insert(object o)
        {
            Node N = new Node();
            N.Next = head;
            N.Data = o;
            head = N;
            count++;
        }

        

        public void Insert(object o, int i)
        {
            if (i == 0)
            {
                Insert(o);
                return;
            }
            Node NN = new Node();
            NN.Data = o;
            Node N = new Node();
            N.Next = head;
            for (int j = 0; j < i; j++)
            {
                if (N.Next != null)
                {
                    N = N.Next;
                }
            }
            NN.Next = N.Next;
            N.Next = NN;
            count++;
        }
        
        public void Delete()
        {
            if (count != 0)
            {
                head = head.Next;
                count--;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        public void Delete(int i)
        {
            
            if (i == 0)
            {
                Delete();
                return;
            }
            
            Node N = head;
            try
            {
                if (i < count - 1 && i > 0)
                {
                    for (int j = 0; j < i - 1; j++)
                    {
                        if (N.Next != null)
                        {
                            N = N.Next;
                        }
                    }
                    N.Next = N.Next.Next;
                    count--;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public object Search(int i)
        {
            Node N = head;
            for (int j = 0; j < i; j++)
            {
                N = N.Next;
            }
            return N.Data;
        }

        public bool Contains(object data)
        {
            bool running = true;
            Node N = head;
            while (running)
            {
                if (N.Next == null)
                {
                    running = false;
                }
                if (N.Data == data)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(object data)
        {
            int index = 0;
            Node n = head;
            while (n.Next != null)
            {
                if (n.Data.Equals(data)) return index;
                index++;
                n = n.Next;
            }
            return -1;
            //int index = 0;
            //Node N = head;
            //bool running = true;

            //if (this.Contains(data))
            //{
            //    while (running)
            //    {
            //        if (N.Next == null)
            //        {
            //            running = false;
            //        }
            //        if (N.Data == data)
            //        {
            //            return index;
            //        }
            //        index++;
            //        N = N.Next;
            //    }
            //}
            //else
            //{
            //    index = -1;
            //}
            //return index;
        }

        public override string ToString()
        {
            string s = "";
            Node N = head;
            while (N != null)
            {
                s += N.Data + "\n";
                N = N.Next;
            }
            return s;
        }
    }
}

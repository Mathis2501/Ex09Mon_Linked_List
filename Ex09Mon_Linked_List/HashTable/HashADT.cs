using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashADT : IComparable
    {
        public IComparable[] _hashTable;

        public HashADT(int i)
        {
            _hashTable = new IComparable[i]; 
        }

        public void Insert(IComparable data)
        {
            _hashTable[data.GetHashCode()%_hashTable.Length] = data;
        }

        public IComparable Search(IComparable data)
        {
            if (_hashTable[data.GetHashCode()%_hashTable.Length] != null)
            {
                return _hashTable[data.GetHashCode()%_hashTable.Length];
            }
            return -1;
        }

        public IComparable GetElement(int i)
        {
            return _hashTable[i];
        }

        public bool IndexInUse(int i)
        {
            if (_hashTable[i] != null)
            {
                return true;
            }
            return false;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}

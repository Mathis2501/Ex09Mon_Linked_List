using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable NonReadonlyMemberInGetHashCode

namespace Ex09Mon_Linked_List
{
    public class ClubMember : IComparable
    {
        public int Nr;
        public string FName;
        public string LName;
        public int Age;

        public override string ToString()
        {
            return $"{Nr} {FName} {LName} {Age}";
        }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (this.ToString() == obj.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode() => Math.Abs(Age.GetHashCode() + FName.GetHashCode() + LName.GetHashCode() + Nr.GetHashCode());

        public int CompareTo(object CMN)
        {
            ClubMember CM = (ClubMember) CMN;
            return Nr > CM.Nr ? -1 : (Nr == CM.Nr ? 0 : 1);
        }
    }
}

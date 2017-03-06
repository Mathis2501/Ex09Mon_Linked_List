using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09Mon_Linked_List
{
    public static class CMFactory
    {
        private static char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static Random rnd = new Random();

        private static string GetName(int lng)
        {
            int randomIndex = rnd.Next(0, alpha.Length - 1);
            string res = alpha[randomIndex].ToString();//first letter uppercase

            for (int i = 1; i <= lng; i++)
            {//the rest is lowercase
                randomIndex = rnd.Next(0, alpha.Length - 1);
                res = res + Char.ToLower(alpha[randomIndex]);
            }
            return res;
        }

        public static ClubMember GetClubMember()
        {
            return new ClubMember()
            {
                Age = rnd.Next(0, 99),
                FName = GetName(rnd.Next(3, 7)),
                LName = GetName(rnd.Next(4, 12)),
                Nr = rnd.Next(100000)
            };
        }
    }

}

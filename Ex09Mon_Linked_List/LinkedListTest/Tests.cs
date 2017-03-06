using System;
using Ex09Mon_Linked_List;
using Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTest
{
    [TestClass]
    public class Tests
    {
        private MyList List;
        [TestInitialize]
        public void TestInitializer()
        {
            List = new MyList();
            for (int i = 0; i < 20; i++)
            {
                List.Insert(CMFactory.GetClubMember());
            }
            
        } 

        [TestMethod]
        public void ListCanInsert()
        {
            Assert.AreEqual(20, List.count);
        }

        [TestMethod]
        public void ListCanDelete()
        {
            List.Delete();
            Assert.AreEqual(19, List.count);
        }

        [TestMethod]
        public void CanSearchAndSaveByIndex()
        {
            List.Insert(new ClubMember() {Age = 19, Nr = 10, FName = "John", LName = "Hest"}, 12);
            ClubMember CM = (ClubMember)List.Search(12);
            Assert.AreEqual(10, CM.Nr);
        }

        [TestMethod]
        public void CanFindIndexOf()
        {
            List.Insert(new ClubMember() { Age = 19, Nr = 10, FName = "John", LName = "Hest" }, 12);
            ClubMember CM = (ClubMember)List.Search(12);
            
            Assert.AreEqual(12, List.IndexOf(CM));
        }
    }
}

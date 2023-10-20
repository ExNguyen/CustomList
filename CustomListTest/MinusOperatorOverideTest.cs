using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class MinusOperatorOverideTest
    {
        [TestMethod]
        public void MinusOperatorMethod_CombinedList_FirstListLongerThenSecond()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();

            //Act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);

            
            list2.Add(2);
            list2.Add(4);

            CustomList<int> combinedList = list1 - list2;

            //Assert
            Assert.AreEqual(3, combinedList.Count);
            Assert.AreEqual(1, combinedList[0]);
            Assert.AreEqual(5, combinedList[2]);
            
        }

        [TestMethod]
        public void MinusOperatorMethod_CombinedList_SecondListIsLongerThenFirst()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();

            //Act
            list1.Add(2);
            list1.Add(4);

            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);
            list2.Add(5);

            CustomList<int> combinedList = list1 - list2;

            //Assert
            Assert.AreEqual(3, combinedList.Count);
            Assert.AreEqual(1, combinedList[0]);
            Assert.AreEqual(5, combinedList[2]);
        }

        [TestMethod]
        public void MinusOperatorMethod_OneListEmpty_NewListHasCorrectItems()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();

            //Act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);

            CustomList<int> combinedList = list1 - list2;

            //Assert
            Assert.AreEqual(5, combinedList.Count);
            Assert.AreEqual(1, combinedList[0]);
            Assert.AreEqual(5, combinedList[4]);
        }

        [TestMethod]
        public void MinusOperatorMethd_ItemRemoval_FirstInstanceOfItemShouldBeRemoved()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();

            //Act
            list1.Add(3);
            list1.Add(3);
            list1.Add(3);

            list2.Add(1);
            list2.Add(2);
            list2.Add(3);

            CustomList<int> combinedList = list1 - list2;

            //Assert
            //Assert.AreEqual(2, combinedList.Count);
            Assert.AreEqual(3, combinedList[0]);
            Assert.AreEqual(3, combinedList[1]);
        }
    }
}
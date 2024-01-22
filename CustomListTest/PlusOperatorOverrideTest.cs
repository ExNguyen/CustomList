using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class PlusOperatorOverideTest
    {
        [TestMethod]
        public void PlusOperatorMethod_CombinedList_FirstListLongerThenSecondList()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();

            //Act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);

            list2.Add(4);
            list2.Add(5);

            CustomList<int> combinedList = list1 + list2;

            //Assert
            Assert.AreEqual(5, combinedList.Count);
            Assert.AreEqual(1, combinedList[0]);
            Assert.AreEqual(5, combinedList[4]);

        }

        [TestMethod]
        public void PlusOperatorMethod_CombinedList_SecondListLongerThenFirstList()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();

            //Act
            list1.Add(1);
            list1.Add(2);

            list2.Add(3);
            list2.Add(4);
            list2.Add(5);

            CustomList<int> combinedList = list1 + list2;

            //Assert
            Assert.AreEqual(5, combinedList.Count);
            Assert.AreEqual(1, combinedList[0]);
            Assert.AreEqual(5, combinedList[4]);
        }

        [TestMethod]
        public void PlusOperatorMethod_OneListEmpty_NewListHasCorrectItems()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();

            //Act
            list1.Add(1);
            list1.Add(2);

            CustomList<int> combinedList = list1 + list2;

            //Assert
            Assert.AreEqual(2, combinedList.Count);
            Assert.AreEqual(1, combinedList[0]);
        }
    }
}
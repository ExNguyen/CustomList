using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class RemoveMethodTest
    {
        [TestMethod]
        public void RemoveMethod_CountDecrements_CountDecrementsAsItemsRemoved()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            //Act
            myList.Remove(1);

            //Assert
            Assert.AreEqual(2, myList.Count);
        }

        [TestMethod]
        public void RemoveMethod_ItemRemoval_ReturnTrueWhenItemIsRemoved()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            //Act
            bool removed = myList.Remove(1);

            //Assert
            Assert.IsTrue(removed);
            Assert.AreEqual(2, myList.Count);
        }

        [TestMethod]
        public void RemoveMethod_IncorrectItemRemoval_CountNotDecrementedIfItemNotFoundInList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            //Act
            bool removed = myList.Remove(4);

            //Assert
            Assert.IsFalse(removed);
            Assert.AreEqual(3, myList.Count);
        }

        [TestMethod]
        public void RemoveMethod_ListAfterRemovedItem_RemainingItemsShiftBackwardsInList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            //Act
            myList.Remove(1);

            //Assert
            Assert.AreEqual(2, myList[0]);
            Assert.AreEqual(3, myList[1]);
        }

        [TestMethod]
        public void RemoveMethod_RemoveItem_FirstInstanceOfItemIsRemoved()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(1);

            //Act
            myList.Remove(1);

            //Assert
            Assert.AreEqual(1, myList[2]);
        }


    }
}
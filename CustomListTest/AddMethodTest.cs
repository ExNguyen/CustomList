using CustomList;

namespace CustomListTest;

[TestClass]
public class AddMethodTest
{
    [TestMethod]
    public void AddMethod_AddTwoItems_SecondItemToIndexOne()
    {
        //Arrange
        CustomList<string> myList = new CustomList<string>();

        //Act
        myList.Add("hello");
        myList.Add("world");

        //Assert
        Assert.AreEqual("world", myList[1]);
    }

    [TestMethod]
    public void AddMethod_ListCount_CountIncrementOfItemsAdded()
    {
        //Arrange
        CustomList<int> myList = new CustomList<int>();

        //Act
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);

        //Assert
        Assert.AreEqual(4, myList.Count);
    }

    [TestMethod]
    public void AddMethod_AddTwoItens_FirstItemAtZeroIndex()
    {
        //Arrange
        CustomList<string> myList = new CustomList<string>();

        //Act
        myList.Add("hello");
        myList.Add("world");

        //Assert
        Assert.AreEqual("hello", myList[0]);
    }

    [TestMethod]
    public void AddMethod_CapacityIncrease_CapacityDoubleWhenExceeded()
    {
        //Arrange
        CustomList<int> myList = new CustomList<int>();

        //Act
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Add(5);

        //Assert
        Assert.AreEqual(8, myList.Capacity);
    }

    [TestMethod]
    public void AddMethod_CapacityArrayAfterIncrease_OriginalNumbersInSameIndex()
    {
        //Arrange
        CustomList<int> myList = new CustomList<int>();

        //Act
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Add(5);

        //Assert
        Assert.AreEqual(1, myList[0]);
        Assert.AreEqual(2, myList[1]);
        Assert.AreEqual(3, myList[2]);
        Assert.AreEqual(4, myList[3]);
        Assert.AreEqual(5, myList[4]);
        
    }


}

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

    }

    
}

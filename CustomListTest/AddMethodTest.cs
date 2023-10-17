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
        myList.Add("good-bye");
        myList.Add("world");
        myList.Add("good");
        myList.Add("eveneing");

        //Assert
        Assert.AreEqual("world", myList[1]);
    }

    
}

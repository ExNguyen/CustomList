using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class ToStringMethodOverrideTest
    {
        [TestMethod]
        public void ToStringMethodOveride_ListOfStrings_ListConvertedIntoSrtring()
        {
            //Arrange
            CustomList<string> mylist = new CustomList<string>();
            mylist.Add("hello");
            mylist.Add("world");
            mylist.Add("goodbye");
            mylist.Add("world");

            //Act

            mylist.ToString();

            //Assert
            Assert.AreEqual("hello, world, goodbye, world", mylist.ToString());
        }

        [TestMethod]
        public void ToStringMethodOverride_ListOfInts_ListConvertedIntoString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            //Act
            myList.ToString();

            //Assert
            Assert.AreEqual("1, 2, 3, 4", myList.ToString());
        }

        [TestMethod]
        public void ToStringMethodOverride_EmptyList_EmptyListReturnEmptyString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act

            //Assert
            Assert.AreEqual("", myList.ToString());

        }

    }
}
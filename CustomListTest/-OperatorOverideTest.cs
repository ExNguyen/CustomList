using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class SortMethodTest
    {
        [TestMethod]
        public void SortMethod_ArraySort_SortInReverse()
        {
            //Arrange
            CustomList<int> mylist = new CustomList<int>();
            mylist.Add(1);
            mylist.Add(3);
            mylist.Add(5);
            mylist.Add(7);

            //Act

            mylist.Sort();

            //Assert
            Assert.AreEqual("7, 5, 3, 1", mylist.ToString());

        }
    }
}
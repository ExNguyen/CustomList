using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class PlusOperatorOverideTest
    {
        [TestMethod]
        public void PlusOperatorMethod_ListLength_FirstListLongerThenSecondList()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();

            //Act
            list1.Add(1);

            //Assert
            

        }
    }
}
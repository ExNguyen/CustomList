namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> myList = new CustomList<int>();
            myList.Add(5);
            myList.Add(1);
            myList.Add(8);
            myList.Add(2);

            Console.WriteLine("Before sorting: " + myList.ToString());

            myList.Sort();

            Console.WriteLine("After sorting: " + myList.ToString());

        }
    }
}
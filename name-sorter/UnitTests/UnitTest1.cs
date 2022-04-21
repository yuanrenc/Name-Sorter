using name_sorter;
using NUnit.Framework;

namespace UnitTests
{
    public class unitTests
    {

        [Test]
        public void TestforLoadData()
        {
            Assert.True(ListManager.LoadData("unsorted-names-list.txt") != null, "Load Data sucessfully.");
        }
    }
}

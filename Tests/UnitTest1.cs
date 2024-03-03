using HomeworkWorkspaceNamespace;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void IsInRange_CheckOutput()
        {
            int input = 5, min = 0, max = 10;
            bool result, expected = true;
            result = HomeworkWorkspaceClass.IsInRange(input, min, max);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GenerateName_ReturnsExpectedType()
        {
            string result;
            result = HomeworkWorkspaceClass.GenerateName();
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void GenerateSpecie_ReturnsExpectedType()
        {
            string result;
            result = HomeworkWorkspaceClass.GenerateSpecie();
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void GenerateFamily_ReturnsExpectedType()
        {
            string result;
            result = HomeworkWorkspaceClass.GenerateFamily();
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void GenerateAffectionGrade_ReturnsExpectedType()
        {
            int result;
            result = HomeworkWorkspaceClass.GenerateAffectionGrade();
            Assert.IsInstanceOfType(result, typeof(int));
        }

        [TestMethod]
        public void GenerateRandomWeight_ReturnsExpectedType()
        {
            int result;
            result = HomeworkWorkspaceClass.GenerateRandomWeight();
            Assert.IsInstanceOfType(result, typeof(int));
        }
    }
}
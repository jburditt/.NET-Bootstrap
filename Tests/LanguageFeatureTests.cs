using Demo;

namespace Tests;

[TestClass]
public class LanguageFeatureTests
{
    [TestMethod]
    public void TestExtensionBlocks_IsPalindrome()
    {
        string test1 = "racecar";
        string test2 = "hello";
        Assert.IsTrue(test1.IsPalindrome());
        Assert.IsFalse(test2.IsPalindrome());
    }

    [TestMethod]
    public void TestExtensionBlocks_GradesPassing()
    {
        Assert.IsTrue(Grades.A.Passing);
        Assert.IsFalse(Grades.F.Passing);
    }
}

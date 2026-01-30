namespace Tests;

[TestClass]
public sealed class DesignPatternTests
{
    [TestMethod]
    public void Test_Add_Multiple_Values()
    {
        //var dict = new MultiValueDictionary<string, string>();
        //dict.Add("animal", "tiger");
        //dict.Add("animal", "lion");

        //Assert.AreEqual(2, dict.Flatten().Count());
        //Assert.AreEqual(2, dict.Get("animal").Count());
        //Assert.IsTrue(dict.Get("animal").Contains("tiger"));
        //Assert.IsTrue(dict.Get("animal").Contains("lion"));
        //Assert.IsTrue(dict.Flatten().Any(kv => kv.Key == "animal" && kv.Value == "tiger"));
        //Assert.IsTrue(dict.Flatten().Any(kv => kv.Key == "animal" && kv.Value == "lion"));
    }

    [TestMethod]
    public void Test_Prototype()
    {
        Demo.Prototype.Program.Main(Array.Empty<string>());
    }
}

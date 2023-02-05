using System.Runtime.Serialization;

namespace TestFonct.XUnitTest;

public class Tests
{
  [Fact]
  public void Handlers_CheckResult()
  {
    //Arrange
    var handler = new Handler();

    //Assign
    var a = Handler.Calculator(300, 100);
    var excepted = 3;

    //Assert
    Assert.Equal(a, excepted);
  }

  [Fact]
  public void Handlers_CheckException()
  {
    Assert.Throws<DivideByZeroException>(() => Handler.Calculator(1, 0));
  }

  [Theory]
  [InlineData(300, 2, 10)]
  [InlineData(300, 100, 3)]
  [InlineData(25, 2, 15)]
  [InlineData(250, 5, 25)]
  public void TestMany(int a, int b, int c)
  {
    Assert.Equal(c, Handler.Calculator(a, b));
  }

  [Theory]
  [MemberData(nameof(data))]
  public void Test_Datamember(int a, int b, int c) => Assert.Equal(c, Handler.Calculator(a, b));

  public static IEnumerable<object[]> data => new List<object[]>
    {
        new object[] { 300, 2, 10 },
        new object[] { 300, 100, 3 },
        new object[] { 25, 2, 15 }
    };

  public static IEnumerable<string[]> dataFile()
  {
    string[] lines = File.ReadAllLines(@"D:\Source\Repos\TestFonc\TestFonc\Datas\dataFile.txt");
    yield return lines;
  }
}
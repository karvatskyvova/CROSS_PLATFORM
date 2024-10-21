using System.IO;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void TestCalculateMoves()
    {
        
        char direction = 'N'; 
        int parameter = 2; 
        Program.rules = new string[] { "NENW", "SESW", "WNW", "ESE", "UUDD", "DDUU" }; 

       
        int result = Program.CalculateMoves(direction, parameter);

       
        Assert.Equal(5, result); 
    }
    [Fact]
    public void Test1()
    {
        File.WriteAllLines("INPUT.TXT", new[] { "N", "NUSDDUSE", "UEWWD", "", "U", "WED", "S 3" });
        Program.Main(null);
        string result = File.ReadAllText("OUTPUT.TXT");
        Assert.Equal("34", result);
    }

    [Fact]
    public void Test2()
    {
        File.WriteAllLines("INPUT.TXT", new[] { "", "", "", "", "", "", "N 1" });
        Program.Main(null);
        string result = File.ReadAllText("OUTPUT.TXT");
        Assert.Equal("1", result);
    }

    [Fact]
    public void Test3()
    {
        File.WriteAllLines("INPUT.TXT", new[] { "", "N", "", "", "", "", "S 2" });
        Program.Main(null);
        string result = File.ReadAllText("OUTPUT.TXT");
        Assert.Equal("2", result);
    }

    [Fact]
    public void Test4()
    {
        File.WriteAllLines("INPUT.TXT", new[] { "", "", "", "", "", "", "U 2" });
        Program.Main(null);
        string result = File.ReadAllText("OUTPUT.TXT");
        Assert.Equal("1", result);
    }

    [Fact]
    public void Test5()
    {
        File.WriteAllLines("INPUT.TXT", new[] { "", "", "E", "", "", "", "W 2" });
        Program.Main(null);
        string result = File.ReadAllText("OUTPUT.TXT");
        Assert.Equal("2", result);
    }
}

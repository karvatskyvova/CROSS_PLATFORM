using System;
using Xunit;
using System.IO;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        File.WriteAllText("INPUT.TXT", "4 5\n1 2 10\n2 3 10\n1 3 10\n3 1 -10\n2 3 1");
        Program.Main(Array.Empty<string>());
        string output = File.ReadAllText("OUTPUT.TXT");
        Assert.Equal("0 10 15 20", output);
    }

    [Fact]
    public void Test_NoEdges()
    {
        File.WriteAllText("INPUT.TXT", "3 0");
        Program.Main(Array.Empty<string>());
        string output = File.ReadAllText("OUTPUT.TXT");
        Assert.Equal("0 10 15 20", output);
    }

    [Fact]
    public void Test_NegativeWeights()
    {
        File.WriteAllText("INPUT.TXT", "3 3\n1 2 -1\n2 3 -2\n1 3 -4");
        Program.Main(Array.Empty<string>());
        string output = File.ReadAllText("OUTPUT.TXT");
        Assert.Equal("0 10 15 20", output);
    }
}

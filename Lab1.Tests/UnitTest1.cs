public class UnitTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        string[] input = { "2", "3" }; // Фіктивні дані
        // Act
        long maxStrings = CalculateMaxStrings(input);
        // Assert
        Assert.Equal(9, maxStrings); // Очікуваний результат
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        string[] input = { "1", "5" }; // Фіктивні дані
        // Act
        long maxStrings = CalculateMaxStrings(input);
        // Assert
        Assert.Equal(5, maxStrings); // Очікуваний результат
    }
    [Fact]
    public void Test3()
    {
        // Arrange
        string[] input = { "3", "4" }; // Фіктивні дані
        // Act
        long maxStrings = CalculateMaxStrings(input);
        // Assert
        Assert.Equal(64, maxStrings); // Очікуваний результат
    }
    [Fact]
    public void Test4()
    {
        // Arrange
        string[] input = { "1", "10" }; // Фіктивні дані
        // Act
        long maxStrings = CalculateMaxStrings(input);
        // Assert
        Assert.Equal(10, maxStrings); // Очікуваний результат
    }
    [Fact]
    public void Test5()
    {
        // Arrange
        string[] input = { "2", "8" }; // Фіктивні дані
        // Act
        long maxStrings = CalculateMaxStrings(input);
        // Assert
        Assert.Equal(64, maxStrings); // Очікуваний результат
    }

    private long CalculateMaxStrings(string[] input)
    {
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);
        return (long)Math.Pow(K, N);
    }
}

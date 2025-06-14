namespace MathLibrary.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
         [Fact]
    public void IsEven_EvenNumber_ReturnsTrue()
    {
        bool result = Calculator.IsEven(8);
        Assert.True(result);
    }

    [Fact]
    public void IsEven_OddNumber_ReturnsFalse()
    {
        bool result = Calculator.IsEven(7);
        Assert.False(result);
    }

    [Fact]
    public void IsEven_OddNumber_ReturnsTrue()
    {
        bool result = Calculator.IsEven(0);
        Assert.True(result);
    }

    [Fact]
    public void Divide_twoPositiveNumbers_ReturnsCorrectResult()
    {
        int result = Calculator.Divide(10, 2);
        Assert.Equal(5 ,result);
    }

    [Fact]
    public void Divide_NegativeAndPositive_ReturnsNegative()
    {
        int result = Calculator.Divide(-9, 3);
        Assert.Equal(-3 ,result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        Assert.throws<DivideByZeroException>(() => Calculator.Divide(10, 0));
    }
    
}

namespace MathLibrary.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
         [Fact]
    public void IsEven_EvenNumber_ReturnsTrue()
    {
        bool result = Calculator.IsEven(4);
        Assert.True(result);
    }

    [Fact]
    public void IsEven_OddNumber_ReturnsFalse()
    {
        bool result = Calculator.IsEven(5);
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
        int result = Calculator.Divide(4, 2);
        Assert.Equal(2 ,result);
    }

    [Fact]
    public void Divide_NegativeNumberAndPositiveNumber_ReturnsNegativeResult()
    {
        int result = Calculator.Divide(-6, 2);
        Assert.Equal(-3 ,result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        Assert.throws<DivideByZeroException>(() => Calculator.Divide(12, 0));
    }
    
}
}

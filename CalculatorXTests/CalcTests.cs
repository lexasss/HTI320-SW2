namespace CalculatorXTests;

public class CalcTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void CirclePlot_OK(double r)
    {
        var calc = new Calculator.Calculator();
        Assert.True(calc.CirclePlot(r) > 0);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-1000)]
    public void CirclePlot_Fails(double r)
    {
        var calc = new Calculator.Calculator();

        Assert.Throws<Exception>(() => calc.CirclePlot(r));
    }
}

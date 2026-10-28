namespace CalculatorTest;

[TestClass]
public sealed class CalcTests
{
    [TestMethod]
    public void CirclePlot_OK()
    {
        var calc = new Calculator.Calculator();
        var rs = new double[] { 1, 2, 3 };
        foreach (var r in rs)
            Assert.IsGreaterThan(0, calc.CirclePlot(r));
    }

    [TestMethod]
    public void CirclePlotInvalid()
    {
        var calc = new Calculator.Calculator();

        Assert.Throws<Exception>(() => calc.CirclePlot(-1));
    }
}

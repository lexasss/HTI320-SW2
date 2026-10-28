namespace Calculator;

public class Calculator
{
    public double RectanglePlot(double a, double b)
    {
        if (a < 0 || b < 0)
            throw new Exception();

        return a * b;
    }

    public double CirclePlot(double r)
    {
        if (r < 0)
            throw new Exception();

        return Math.PI * r * r;
    }
    public double SphereVolume(double r)
    {
        if (r < 0)
            throw new Exception();

        return (4.0 / 3.0) * Math.PI * r * r * r;
    }
}

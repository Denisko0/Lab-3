namespace Program;

public class Rectangle
{

    public double Perimeter
    {
        get { return this.PerimeterCalculator(); }
    }

    public double Area
    {
        get { return this.AreaCalculator(); }
    }

    private double first_side;
    private double second_side;

    public override string ToString()
    {
        return $"{AreaCalculator()} {PerimeterCalculator()}";
    }

    public Rectangle(double first_side, double second_side)
    {
        this.first_side = first_side;
        this.second_side = second_side;
    }

   

    double AreaCalculator()
    {
        return this.first_side * this.second_side;
    }

    double PerimeterCalculator()
    {
        return 2 * (this.first_side + this.second_side);
    }
}

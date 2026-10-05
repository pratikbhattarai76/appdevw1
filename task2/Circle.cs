class Circle
{
    public const double Pi = 3.14;

    public static double CalculateArea(double radius)
    {
        return Pi * radius * radius;
    }

    public static double CalculatePerimeter(double radius)
    {
        return 2 * Pi * radius;
    }
}
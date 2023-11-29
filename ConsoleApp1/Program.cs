using System;

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}

public class AreaCalculator
{
    public double CalculateArea(object shape)
    {
        if (shape is Rectangle)
        {
            
            var rectangle = (Rectangle)shape;
            return rectangle.Width * rectangle.Height;
        }

        throw new ArgumentException("Unsupported shape type", nameof(shape));
    }
}


/*
public class Circle
{
    public double Radius { get; set; }
}

*/


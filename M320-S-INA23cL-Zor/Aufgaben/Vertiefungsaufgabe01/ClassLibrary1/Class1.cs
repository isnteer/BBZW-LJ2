namespace ClassLibrary1;

public class Cuboid
{
    
    public double Length { get; }
    public double Width { get; }
    public double Height { get; }

    public Cuboid(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }
    
    public double GetVolume()
    {
        return Length * Width * Height; 
    }

    public double GetSurfaceArea()
    {
        return 2 * (Length * Width) + 2 * (Width * Height) + 2 * (Height * Length);
    }

    public double GetBaseArea()
    {
        return Length * Width;
    }

    public double GetDiagonal()
    {
        W
    }
    
}
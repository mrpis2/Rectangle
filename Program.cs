using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the width:");
        double width = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height:");
        double height = Double.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(width, height);
        Console.WriteLine(rectangle.Display());
        Console.WriteLine(rectangle.GetArea());
    }
}

public class Rectangle
{
    double width, height;
    public Rectangle()
    {
    }
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public double GetArea()
    {
        return (this.width + this.height) *2;
    }
    public string Display()
    {
        return "Rectangle{" + "width=" + width + ", height=" + height + "}";
    }



}
// ---------------------
// Intro to Programming
// Week 7 In Class Test
// Task 3: Calculates area, perimeter and Square-ness 
// ------- of Rectangles from 2 user inputs, can also
// ------- do Triangles and determine their type.
// Code by Jacob Lummis
// ARUP SID: 2213276
// ---------------------
// Class file for task 3

public class MyRec
{
// Initialise Attributes
double width;
double depth;
double area;
double perimeter;

// Methods
    public MyRec(double w, double d)
    {
        width = w;
        depth = d;
        area = (width * depth);
        perimeter = (2 * width) + (2 * depth);
    }
    public void getRecArea()
    {
        Console.WriteLine("\n\tThe Area of your garden is " + area.ToString("n2") + " units squared.");
    }
    public void getRecPerimeter()
    {
        Console.WriteLine("\n\tThe Perimeter of your garden is " + perimeter.ToString("n2") + " units.");
    }
    public string getRecDepth()
    {
        return(depth.ToString("n2"));
    }
    public string getRecWidth()
    {
        return(width.ToString("n2"));
    }
    public void getSquareness()
    {
        if (width == depth)
        {
            Console.WriteLine("\n\tYour Garden is Square, Symmetry for the win!");
        }
        else
        {
            Console.WriteLine("\n\tYour Garden is not square.");
        }
    }
}

public class MyTriangle
{
    
}
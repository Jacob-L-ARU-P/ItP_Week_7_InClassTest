// ---------------------
// Intro to Programming
// Week 7 In Class Test
// Task 3: Calculates area, perimeter and Square-ness 
// ------- of Rectangles from 2 user inputs, can also
// ------- do Triangles and determine their type.
// Code by Jacob Lummis
// ARUP SID: 2213276
// ---------------------
// Declare Variable(s)

int UserChoice = 0;

// Program Start Fluff
Console.WriteLine("\tWelcome to Garden Space Calculator(tm)(Version 1)\n\tOption 1: Regular Yard\n\tOption 2: Irregular Yard\n\tOption 3: Exit");

// Program Main Loop
while (UserChoice != 3)
{
// Error Handling
    try
    {
// User Inputs and Choices
        Console.Write("\n\tPlease chose an Option: ");
        switch(UserChoice = Convert.ToInt32(Console.ReadLine()))
        {
            case 1:
            {
                Console.WriteLine("\tPlease Enter the two Perpendicular lengths of your garden, these being;\n\tThe Depth, the distance from the back of your home to the far end of your garden and;\n\tThe Width, the distance from one side of the garden to the other, moving parallel to your home.");
                Console.Write("\tDepth: ");
                double d = Convert.ToDouble(Console.ReadLine());
                Console.Write("\tWidth: ");
                double w = Convert.ToDouble(Console.ReadLine());
                MyRec UserRectangle = new MyRec(w,d);
                Console.WriteLine("\n\tYour garden is " + UserRectangle.getRecDepth() + " units deep and, " + UserRectangle.getRecWidth() + " units wide.");
                UserRectangle.getRecArea();
                UserRectangle.getRecPerimeter();
                UserRectangle.getSquareness();
                break;
            }
            case 2:
            {

                break;
            }
            case 3:
            {
                Console.Write("\n\n\tPress any key to exit.");
                break;
            }
            default:
            {
                Console.WriteLine("\tInvalid input detected, please try again.");
                break;
            }
        }
    } 
// What to do if Broke    
    catch (FormatException)
    {
        Console.WriteLine("\n\tException Thrown. Please only enter numbers using 0-9 (Zero to Nine) and '.' (full stops)");
        UserChoice = 0;
    }
    catch (OverflowException)
    {
        Console.WriteLine("\n\tException Thrown. Please only enter numbers using 0-9 (Zero to Nine) and '.' (full stops)");
        UserChoice = 0;
    }
}
//
Console.ReadKey();
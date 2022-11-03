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

// Program Main Loop
while (UserChoice != 9)
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
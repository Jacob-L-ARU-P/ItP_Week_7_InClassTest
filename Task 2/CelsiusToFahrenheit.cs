// ---------------------
// Intro to Programming
// Week 7 In Class Test
// Task 2: Temperature Converter, Converts between;
// ------- Celsius, Fahrenheit and Kelvin.
// Code by Jacob Lummis
// ARUP SID: 2213276
// ---------------------
// Declare initial Variable(s)

int UserChoice = 0;
double UserInput = 0.00;

// Program Start Fluff
Console.WriteLine("\tWelcome to 'KFC! Conversions' What can we do for you today?");
Console.WriteLine("\tKFC: Kelvin-Fahrenheit-Celsius Conversions!\n\tConverting Temperatures between measurement types since 2022!\n\tNo affiliation with the KFC fast food brand.\n");
Console.WriteLine("\tOption 1: Celsius to Fahrenheit conversion.\n\tOption 2: Celsius to Kelvin conversion.\n\tOption 3: Fahrenheit to Celsius conversion.");
Console.WriteLine("\tOption 4: Fahrenheit to Kelvin conversion.\n\tOption 5: Kelvin to Celsius conversion.\n\tOption 6: Kelvin to Fahrenheit conversion.");
Console.WriteLine("\tOption 7: Exit.");

// Main Loop
while(UserChoice != 7)
{
// Error Handling of user inputs
    try
    {
        Console.Write("\n\tPlease chose an Option: ");
        switch(UserChoice = Convert.ToInt32(Console.ReadLine()))
        {
        case 1:
        {
            Console.Write("");
            break;
        }
        case 2:
        {

            break;
        }
        case 3:
        {

            break;
        }
        case 4:
        {

            break;
        }
        case 5:
        {

            break;
        }
        case 6:
        {

            break;
        }
        case 7:
        {
            Console.WriteLine("\n\tThank you for using 'KFC! Conversions', have a great day!");
            break;
        }
        default:
        {
            Console.WriteLine("\tInvalid input detected, please try again.");
            break;
        }
        }
    }
// Prevent the program from breaking thanks
    catch(FormatException)
    {

    }
    catch(OverflowException)
    {

    }
}

// Exit Hold Line
Console.WriteLine("\n\tPress any key to exit.");
Console.ReadKey();
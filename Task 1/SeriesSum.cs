// ---------------------
// Intro to Programming
// Week 7 In Class Test
// Task 1: Series Series Calculator
// ------- Calculates Series of X numbers, input by user
// Code by Jacob Lummis
// ARUP SID: 2213276
// ---------------------
// Declare initial Array(s) and other variables

float[] TestSeries = new float[5];
TestSeries[0] = 3.4F;
TestSeries[1] = 6.7F;
TestSeries[2] = 8.3F;
TestSeries[3] = 9.0F;
TestSeries[4] = 2.4F;

float TestSeriesSum = 0;

double[] UserSeriesC = new double[5];
double UserSeriesCSum = 0;

double[] UserSeriesU = new double[] {};
double UserSeriesUSum = 0;

int UserChoice = 0;

// Program Methods
// Example Series method
void ExampleSeriesSum()
{
    Console.WriteLine("");
    for(int i = 0; i < 5; i++)
    {
        TestSeriesSum =  TestSeriesSum + TestSeries[i];
        Console.WriteLine("\tValue " + (i + 1) + " of Example Series is: " + TestSeries[i]);
    }
    TestSeriesSum = TestSeriesSum / TestSeries.Length;
    Console.WriteLine("\n\tSum of Example Series is: " + TestSeriesSum);
}

// User constrained input Series Method (Extension 1)
void UserCSeriesSum()
{
    Console.WriteLine("");
    for(int i = 0; i < 5; i++)
    {
        Console.Write("\tPlease input value " + (i + 1) + " for your series: ");
        UserSeriesC[i] = Convert.ToDouble(Console.ReadLine());
        UserSeriesCSum = UserSeriesCSum + UserSeriesC[i];
    }
    UserSeriesCSum = UserSeriesCSum / UserSeriesC.Length;
    Console.WriteLine("\n\tSum of Your Series is: " + UserSeriesCSum);
}

// User unconstrained input Series Method (Extension 2)
void UserUSeriesSum()
{
    Console.WriteLine("\tWork in Progress");
}

// Program start fluff
Console.WriteLine("\tWelcome to Series Series Calculator Version 2.3!");
Console.WriteLine("\tOption 1: View Default Series of 5 numbers and its Sum");
Console.WriteLine("\tOption 2: Input 5 values of your choice and see the Sum");
Console.WriteLine("\tOption 3: Chose number of values to enter, then see the Sum");
Console.WriteLine("\tOption 4: Declare a generic expression, its bounds,\n\tand see the Sum (CURRENTLY UNAVAILABLE)");
Console.WriteLine("\tOption 5: Exit");
while(UserChoice != 5)
{
    try
    {
    Console.Write("\n\tPlease chose an Option: ");
    switch(UserChoice = Convert.ToInt32(Console.ReadLine()))
    {
    case 1:
    {
        ExampleSeriesSum();
        break;
    }
    case 2:
    {
        UserCSeriesSum();
        break;
    }
    case 3:
    {
        UserUSeriesSum();
        break;
    }
    case 4:
    {
        Console.WriteLine("\tOption 4 is currently unavailable, please chose another option.");
        break;
    }
    case 5:
    {
        Console.WriteLine("\n\tThank your for using Series Calculator Version 2.3, have a nice day!");
        break;
    }
    default:
    {
        Console.WriteLine("\tInvalid input detected, please try again.");
        break;
    }
    }
    }
    catch (FormatException)
    {
        Console.WriteLine("\n\tException Thrown. Please only enter numbers 0-9 (Zero through Nine)");
        UserChoice = 0;
    }
}
// Exit Hold Line
Console.WriteLine("\n\tPress any key to exit.");
Console.ReadKey();
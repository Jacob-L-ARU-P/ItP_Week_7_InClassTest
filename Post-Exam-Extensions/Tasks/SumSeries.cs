// ---------------------
// Task 1: Series Series Calculator
// ------- Calculates Series of X numbers, input by user
// Code by Jacob Lummis
// ARUP SID: 2213276
// ---------------------
// Part 1; Example Series
public class Test
{
// Class Constructor
    public Test()
    {
    }
// Class Method(s)
    public void ESS2()
    {
        // Static/Dependant Variables
        float[] TestSeries2 = new float[5] {3.4f, 6.7f, 8.3f, 9.0f, 2.4f};
        float TestSeriesSum2 = 0;
        // Possible Pre-Loop Formatting

        // The Example Loop
        for(int i = 0; i < 5; i++)
        {
            TestSeriesSum2 =  TestSeriesSum2 + TestSeries2[i];
            Console.WriteLine("\tValue " + (i + 1) + " of Example Series is: " + TestSeries2[i]);
        }
        TestSeriesSum2 = TestSeriesSum2 / TestSeries2.Length;
        Console.WriteLine("\n\tMean of Example Series is: " + TestSeriesSum2);    
    }
}
// Part 2; User Series Class
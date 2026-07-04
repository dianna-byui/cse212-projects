public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // First, make a new array named multiples.
        // The array has the size from length.
        // This array will save all the multiples.
        double[] multiples = new double[length];

        // This loop go to each place in the array.
        // The for loop starts at 0 because arrays start at 0.
        // Keep going until all places have a value.
        for (int i = 0; i < length; i++)
        {
            // Find the next multiple with the formula number * (i + 1).
            // Use i + 1 so the first number is the number itself.
            // Save the value in the array.
            multiples[i] = number * (i + 1);
        }

        // Return the array.
        return multiples;

    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {

        // The for loop continues until the amount is done.
        // Every time, we move one number from the end to the front.
        for (int i = 0; i < amount; i++)
        {
            // Save the last number.
            // We need to save it before removing it.
            int lastValue = data[data.Count - 1];

            // Remove the last number from the list with the RemoveAt method.
            data.RemoveAt(data.Count - 1);

            // The number that was saved in lastValue, we put it at the front.
            // This moves the list one place to the right using the Insert method.
            data.Insert(0, lastValue);
        }

    }
}

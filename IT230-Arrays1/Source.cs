/*
 * Name: [YOUR NAME HERE]
 * South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
 */
//DO NOT USE LINQ!

namespace IT230_Arrays1
{
    public class Source
    {
        // The players array does not count towards your memory limit
        public static int[] players; // Do not initialize the array here

        /// <param name="number">
        /// This parameter refers to the value to be deleted from the array,
        ///     not the index.
        /// </param>
        public static void InsertIntoArray(int number)
        {
            // TODO: Append the argument to the array
        }

        /// <param name="number">
        /// This parameter refers to the value to be deleted from the array,
        ///     not the index.
        /// </param>
        /// <returns>
        /// Returns the index of the element in the array. 
        /// If the element does not exist, return -1.
        /// </returns>
        public static int SearchArray(int number)
        {
            // TODO: Return the index of where the argument exists in the array.
            return -1;
        }

        /// <param name="number">
        /// This parameter refers to the value to be deleted from the array,
        ///     not the index.
        /// </param>
        public static void DeleteFromArray(int number)
        {
            // TODO: Delete the argument from the array. If the
            //  argument does not exist in the array, do nothing.
            // Remember, array elements must be contiguous. "Resize"
            //  the array properly.
        }
    }
}
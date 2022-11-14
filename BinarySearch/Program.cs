internal class Program
{
    public static void Main()
    {
        var array = new[] { 1, 2, 3, 4, 5, 5, 5, 6 };
        Console.WriteLine(FindIndexByBinarySearch(array, 5));
    }

    static int FindIndexByBinarySearch(int[] array, int element)
    {
        var left = 0;
        var right = array.Length - 1;
        while (left < right)
        { 
            var middle = (right + left) / 2;
            if (element <= array[middle])
            {
                right = middle;
            }
            else left = middle + 1;
        }
        if (array[right] == element)
        {
            return right;
        }
        return -1;
    }
}
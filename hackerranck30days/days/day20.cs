class day20
{
    public static void day20Main()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        // Write your code here
        int numberOfSwaps = 0;
        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < n - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    (a[j], a[j + 1]) = (a[j + 1], a[j]);
                    numberOfSwaps++;
                }
            }

            if (numberOfSwaps == 0)
            {
                break;
            }
        }

        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
        Console.WriteLine("First Element: " + a[0]);
        Console.WriteLine("Last Element: " + a.Last());

    }
}
namespace _09_StrategyPattern;

public class QuickSortStrategy : ISortStrategy
{
    public void Sort(List<int> list)
    {
        Console.WriteLine("Using Quick Sort");
        QuickSort(list, 0, list.Count - 1);
    }

    private static void QuickSort(IList<int> list, int left, int right)
    {
        while (true)
        {
            if (left >= right)
            { 
                return;
            }

            int pivot = Partition(list, left, right);

            QuickSort(list, left, pivot - 1);

            left = pivot + 1;
        }
    }

    private static int Partition(IList<int> list, int left, int right)
    {
        int pivot = list[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (list[j] >= pivot)
            {
                continue;
            }

            i++;

            (list[i], list[j]) = (list[j], list[i]);
        }

        (list[i + 1], list[right]) = (list[right], list[i + 1]);

        return i + 1;
    }
}
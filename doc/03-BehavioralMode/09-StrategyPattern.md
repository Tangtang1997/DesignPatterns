# Overview

A Strategy Pattern is a behavioral design pattern that defines a series of algorithms and encapsulates each one so that they are interchangeable. The policy pattern allows the algorithm to vary independently of the client using it. By using the policy pattern, different algorithms can be selected at run time, thus improving the flexibility and maintainability of the system.

# Structure

The policy pattern contains the following roles:

1. Strategy: Defines the common interface of all supported algorithms.
2. ConcreteStrategy: A specific algorithm for implementing policy interfaces.
3. Context: Maintains a reference to a policy object and invokes the methods of the policy object when needed.

# Sample Code

Suppose we have an application that needs to sort a set of numbers, we can choose different sorting algorithms (such as bubble sort and quick sort).

**Strategy Interface**

```csharp
public interface ISortStrategy
{
    void Sort(List<int> list);
}
```

**Specific Strategies**

```csharp
public class BubbleSortStrategy : ISortStrategy
{
    public void Sort(List<int> list)
    {
        Console.WriteLine("Using Bubble Sort");
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                }
            }
        }
    }
}

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
```

**Context**

```csharp
public class SortContext
{
    private ISortStrategy _sortStrategy;

    public void SetSortStrategy(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    public void Sort(List<int> list)
    {
        _sortStrategy.Sort(list);
    }
}
```

**Client Code**

```csharp
class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int> { 5, 2, 9, 1, 5, 6 };

        SortContext context = new SortContext();

        context.SetSortStrategy(new BubbleSortStrategy());
        context.Sort(list);
        Console.WriteLine(string.Join(", ", list));

        list = new List<int> { 5, 2, 9, 1, 5, 6 };

        context.SetSortStrategy(new QuickSortStrategy());
        context.Sort(list);
        Console.WriteLine(string.Join(", ", list));
    }
}
```

# Application Scenarios

The policy mode applies to the following scenarios:

1. Need to use multiple algorithms: When a system needs to choose one of multiple algorithms, you can use the policy mode.
2. Algorithm independent change: When the implementation of the algorithm needs to be independent of the change of the client using it, the policy mode can be used.
3. Eliminate conditional statements: When a system contains a large number of conditional statements to choose the appropriate algorithm, you can use the policy mode to replace these conditional statements with the encapsulation of the algorithm.

# Advantages and disadvantages

**Advantages**

* Algorithms can change independently: Policy mode allows algorithms to change independently of the clients using it, improving the flexibility and maintainability of the system.
* Eliminate conditional statements: The policy pattern eliminates conditional statements from the system by encapsulating algorithms into separate policy classes.

**Disadvantages**

*Increase the number of classes: The policy pattern introduces a large number of policy classes, which may increase the complexity of the system.
* The client must understand the different policies: The policy pattern requires the client to understand the different policy classes and choose the appropriate policy on its own.
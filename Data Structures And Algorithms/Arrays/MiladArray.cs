using System.Collections;

namespace Data_Structures_And_Algorithms.Arrays;

public class MiladArray
{
    // indexes in memory 
    // 100  104  108  112  116
    // numbers
    // 10 - 20 - 30 - 40 - 50
    // Lookup O(1)

    // Search for value O(n)

    // Add O(n)

    // Delete O(1) -> Best
    // Delete O(n) -> Worst

    private int[] array;
    private int arrayLenght;
    private int insertIndex = 0;

    public MiladArray(int arrayLength)
    {
        array = new int[arrayLength];
        this.arrayLenght = arrayLength;
    }

    public void Print()
    {
        for (var index = 0; index < insertIndex; index++)
        {
            Console.WriteLine(array[index]);
        }
    }

    public void Add(int value)
    {
        if (insertIndex >= arrayLenght)
            DoubleArrayLength();
        
        array[insertIndex] = value;
        insertIndex++;
    }

    public void RemoveAt(int index)
    {
        var counter = index;
        if (insertIndex >= arrayLenght)
            DoubleArrayLength();
        while (counter < insertIndex)
        {
            array[counter] = array[counter + 1];
            counter++;
        }

        insertIndex--;
    }

    public int IndexOf(int value)
    {
        for (var index = 0; index < array.Length; index++)
        {
            if (array[index] == value)
                return index;
        }
        return -1;
    }

    private void DoubleArrayLength()
    {
        var oldArray = new int[arrayLenght];
        for (var index = 0; index < array.Length; index++)
        {
            var item = array[index];
            oldArray[index] = item;
        }
        arrayLenght *= 2;
        array = new int[arrayLenght];
        for (var index = 0; index < oldArray.Length; index++)
        {
            var item = oldArray[index];
            array[index] = item;
        }
    }

    public void ArrayMain()
    {
        // int[] numbers = {10, 20, 30};
        // foreach (var number in numbers)
        // {
        //     Console.Write(number + " ,");
        // }

        // ArrayList numbers = new ArrayList();
        // numbers.Add(10);
        // numbers.Add(20);
        // numbers.Add(30);
        // numbers.Add(40);
        //
        // numbers.RemoveAt(3);
        // Console.Write(numbers.IndexOf(40));

        MiladArray numbers = new MiladArray(3);
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);

        numbers.Print();
        
        numbers.RemoveAt(2);

        numbers.Print();
        Console.Write(numbers.IndexOf(50));
    }
}
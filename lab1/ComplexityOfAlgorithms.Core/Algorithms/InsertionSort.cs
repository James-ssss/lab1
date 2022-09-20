namespace ÑomplexityOfAlgorithms.Algorithms;

public class InsertionSort
{
    public static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    public static int[] InsertSort(int[] vector)
    {
        int x;
        int j;
        for (int i = 1; i < vector.Length; i++)
        {
            x = vector[i];
            j = i;
            while (j > 0 && vector[j - 1] > x)
            {
                Swap(vector, j, j - 1);
                j -= 1;
            }
            vector[j] = x;
        }

        return vector;
    }
}
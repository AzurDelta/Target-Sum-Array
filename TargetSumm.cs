namespace Target_Sum_Array;

public class TargetSumm
{

    public static (int,int) TargetSummArray(int[] array, int targetSum)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[i] + array[j] == targetSum)
                    return (i, j);
            }
        }
        return (-1, -1);
    }
}
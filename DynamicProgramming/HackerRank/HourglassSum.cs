namespace DynamicProgramming.HackerRank
{
    public static class HourglassSum
    {
        /*
         * Given a 6x6 2D array.
         * An hourglass is a subset of values with indices falling in this pattern:
         *      a b c
         *        d
         *      f g h
         * There are 16 hourglasses in the 6x6 2D array. An hourglass sum is the sum of an hourglass's values.
         * Calculate the hourglass sum for every hourglass in the Array, then return the maximum
         * hourglass sum.
         * 
         * 1. f(i) is the maximum hourglass sum
         * 2. 0 <= i <= 3 and 0 <= j <= 3, these are the restrictions | edge cases
         * 3. f(i) = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]
         * 4. array[i][j] to array[i + 2][j + 2], order of computation
         * 5. maxSum[15]
         */
        public static int Solution(List<List<int>> arr)
        {
            int[] maxSum = new int[16];
            int sumIndex = 0;

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    int topSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2];
                    int mid = arr[i + 1][j + 1];
                    int botSum = arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    var hourglassSum = topSum + mid + botSum;

                    if (sumIndex == 0)
                    {
                        maxSum[sumIndex] = hourglassSum;
                        
                        sumIndex++;

                        continue;
                    }
                    if (maxSum[sumIndex - 1] < hourglassSum)
                    {
                        maxSum[sumIndex] = hourglassSum;
                    }
                    else
                    {
                        int aux = maxSum[sumIndex - 1];
                        maxSum[sumIndex - 1] = hourglassSum;
                        maxSum[sumIndex] = aux;
                    }
                    sumIndex++;
                }
            }

            return maxSum[15];
        }
    }
}

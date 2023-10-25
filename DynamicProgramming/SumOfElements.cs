namespace DynamicProgramming
{
    public static class SumOfElements
    {
        public static int RecursionSolution(int n)
        {
            if(n == 0) return 0;
            if(n == 1) return 1;

            return RecursionSolution(n - 1) + n;
        }

        public static int LoopSolution(int n)
        {
            int[] dp = new int[n+1];
            dp[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                dp[i] = dp[i - 1] + i;
            }

            return dp[n];
        }
    }
}

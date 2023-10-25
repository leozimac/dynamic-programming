namespace DynamicProgramming
{
    /*
     * Paid Staircase problem:
     * 
     * You are climbing a paid staircase. It takes n steps to reach to the top and you have to
     * pay p[i] to step on the i-th stair. Each time you can climb 1 or 2 steps.
     * What's the cheapest amount you have to pay to get to the top of the staircase?
     */

    /*
     * 1. Define the objective function:
     *  f(i) is the cheapest amount to pay to get to the top
     * 
     * 2. Identify, base/edge cases:
     *  f(0) = 0
     *  f(1) = p[1]
     *  
     * 3. Recurrence relation
     *  f(n) = p(n) + min(f(n-1), f(n-2))
     * 
     * 4. Order of computation:
     *  Bottom up
     *  
     * 5. Location of the anwser
     *  f(n)
     */
    public static class PaidStaircase
    {
        public static int Solution(int n, int[] p)
        {
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = p[1];

            for (int i = 2; i <= n; i++)
            {
                dp[i] = p[i] + Math.Min(dp[i - 1], dp[i - 2]);
            }

            return dp[n];
        }
    }
}

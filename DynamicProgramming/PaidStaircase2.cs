namespace DynamicProgramming
{
    /*
     * Paid Staircase problem:
     * 
     * You are climbing a paid staircase. It takes n steps to reach to the top and you have to
     * pay p[i] to step on the i-th stair. Each time you can climb 1 or 2 steps.
     * What's the cheapest path get to the top of the staircase?
     */

    /*
     * Method to reconstruct the solution
     * path = [];
     * for(int curr = best_last_state; curr exists; curr = from[curr])
     * {
     *      path.push(curr);
     * }
     */

    public static class PaidStaircase2
    {
        public static int[] Solution(int n, int[] p)
        {
            int[] from = new int[n + 1];
            int[] dp = new int[n + 1];

            dp[0] = 0;
            dp[1] = p[1];

            for (int i = 2; i <= n; i++)
            {
                dp[i] = p[i] + (Math.Min(dp[i - 1], dp[i - 2]));
                
                if (dp[i - 1] < dp[i - 2])
                    from[i] = i - 1;
                else
                    from[i] = i - 2;
            }

            List<int> path = new List<int>();
            for (int curr = n; curr >= 0; curr = from[curr])
            {
                path = path.Append(curr).ToList();
                if (curr == 0) break;
            }

            path.Reverse();
            return path.ToArray();
        }

        public static int[] Solution2(int n, int[] p)
        {
            // substituir from por uma pilha
            int[] from = new int[n + 1];
            Stack<int> stack = new Stack<int>();

            int[] dp = new int[n + 1];

            dp[0] = 0;
            dp[1] = p[1];

            for (int i = 2; i <= n; i++)
            {
                dp[i] = p[i] + (Math.Min(dp[i - 1], dp[i - 2]));

                if (dp[i - 1] < dp[i - 2])
                {
                    if(!stack.Contains(i - 1))
                        stack.Push(i - 1);
                }
                else
                {
                    if(!stack.Contains(i - 2))
                        stack.Push(i - 2);
                }
            }

            stack.Push(n);
            return stack.Reverse().ToArray();
        }
    }
}

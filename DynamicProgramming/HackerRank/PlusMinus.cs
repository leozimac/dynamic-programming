namespace DynamicProgramming.HackerRank
{
    public static class PlusMinus
    {
        public static void plusMinus(List<int> arr)
        {
            var proportions = new Dictionary<string, int>();

            proportions.Add("positives", 0);
            proportions.Add("negatives", 0);
            proportions.Add("zeros", 0);

            foreach (var item in arr)
            {
                if (item == 0)
                    proportions["zeros"] += 1;
                if (item > 0)
                    proportions["positives"] += 1;
                if (item < 0)
                    proportions["negatives"] += 1;
            }

            foreach (var item in proportions)
            {
                Console.WriteLine($"{(float)item.Value / arr.Count()}");
            }
        }
    }
}

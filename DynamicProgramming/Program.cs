using DynamicProgramming;
using DynamicProgramming.HackerRank;

//int n = 8;
//int[] p = new int[] { 0, 3, 2, 4, 6, 1, 1, 5, 3};

//Console.WriteLine($"N is {n}");
//Console.WriteLine($"The Sum of {n} elements is:");
//Console.WriteLine(SumOfElements.LoopSolution(n));

//Console.WriteLine($"The cheapest amount to get to the top is:");
//Console.WriteLine(PaidStaircase.Solution(n, p));

//Console.WriteLine($"The cheapest path to get to the top is:");
//var solution = PaidStaircase2.Solution(n, p);
//var solution2 = PaidStaircase2.Solution2(n, p);

//for (int i = 0; i < solution.Length; i++)
//{
//    Console.Write($"{solution[i]} ");
//}

//Console.WriteLine();
//for (int i = 0; i < solution2.Length; i++)
//{
//    Console.Write($"{solution2[i]} ");
//}

//int[] k = new int[] { 2, 2, 2 };
//int sol = SmallestAmount.Solution(k);
//Console.WriteLine(sol);

//int[] a = new int[] { 2, 3, 4 };
//int[] b = new int[] { 4, 2, 5, 6 };
//int x = 5;
//int sol = DifferenceBetweenTwoSetOfCards.Solution(a, b, x);
//Console.WriteLine(sol);

//var arr = new List<int> { 1, 1, 0, -1, -1 };
//PlusMinus.plusMinus(arr);

var s = "middle-Outz";
var k = 2;
Console.WriteLine(CaesarCipher.caesarCipher(s, k));
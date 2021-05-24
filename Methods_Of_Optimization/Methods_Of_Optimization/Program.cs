using System;

namespace Methods_Of_Optimization
{
    class Program
    {
		static float f1(Vector x)
		{
			return 100 * MathF.Pow(MathF.Pow(x[0], 2) - x[1], 2) + MathF.Pow(1 - x[0], 2);
		}
		static float f2(Vector x)
		{
			return 100 * MathF.Pow(x[1] - MathF.Pow(x[0], 3), 2) + MathF.Pow(1 - x[0], 2);
		}
		static float f3(Vector x)
		{
			return 100 * MathF.Pow(x[1] - MathF.Pow(x[0], 3), 2) + MathF.Pow(1 - x[0], 2);
		}
		static float f4(Vector x)
		{
			return MathF.Pow(x[0] + 10 * x[1], 2) + 5 * MathF.Pow(x[2] - x[3], 2) +
				MathF.Pow(x[1] - 2 * x[2], 4) + 10 * MathF.Pow(x[0] - x[3], 4);
		}
		static void Main(string[] args)
        {
			Methods.Result[,] results = new Methods.Result[4, 2];
			results[0, 0] = Methods.PatternSearch(f1, new float[] { -1.2f, 1 }, 0.7f, 1.5f, 0.000001f);
			results[0, 1] = Methods.SimplexMethod(f1, new float[] { -1.2f, 1 }, 0.00000000001f, 1, 0.7f, 1.7f);
			results[1, 0] = Methods.PatternSearch(f2, new float[] { -1.2f, -1 }, 0.7f, 1.5f, 0.000001f);
			results[1, 1] = Methods.SimplexMethod(f2, new float[] { -1.2f, -1 }, 0.00000000001f, 1, 0.7f, 1.7f);
			results[2, 0] = Methods.PatternSearch(f3, new float[] { 0f, 0 }, 0.7f, 1.5f, 0.000001f);
			results[2, 1] = Methods.SimplexMethod(f3, new float[] { 0f, 0 }, 0.00000000001f, 1, 0.7f, 1.7f);
			results[3, 0] = Methods.PatternSearch(f4, new float[] { 3, -1, 0, 1 }, 0.7f, 1.5f, 0.000001f);
			results[3, 1] = Methods.SimplexMethod(f4, new float[] { 3, -1, 0, 1 }, 0.00000000001f, 1, 0.7f, 1.7f);

			Console.WriteLine("Pattern Search:");
			Console.WriteLine("Function: 100*(x1^2-x2)^2 + (1-x1)^2");
			Console.WriteLine("Starting point: (-1.2,1)");
			Console.WriteLine($"Solution: {results[0, 0].result}");
			Console.WriteLine($"Result: {f1(results[0, 0].result)}");
			Console.WriteLine($"Iteration: {results[0, 0].iteration}");
			Console.WriteLine("---------------------------------------------");

			Console.WriteLine("Function: 100*(x2-x1^3)^2 + (1-x1)^2");
			Console.WriteLine("Starting point: (-1.2,-1)");
			Console.WriteLine($"Solution: {results[1, 0].result}");
			Console.WriteLine($"Result: {f1(results[1, 0].result)}");
			Console.WriteLine($"Iteration: {results[1, 0].iteration}");
			Console.WriteLine("---------------------------------------------");

			Console.WriteLine("Function: 100*(x1^2-x2)^2 + (1-x1)^2");
			Console.WriteLine("Starting point: (0,0)");
			Console.WriteLine($"Solution: {results[2, 0].result}");
			Console.WriteLine($"Result: {f1(results[2, 0].result)}");
			Console.WriteLine($"Iteration: {results[2, 0].iteration}");
			Console.WriteLine("---------------------------------------------");

			Console.WriteLine("Function: (x1+10*x2)^2 + 5*(x3-x4)^2 + (x2-2*x3)^4 + 10*(x1-x4)^4");
			Console.WriteLine("Starting point: (3,-1,0,1)");
			Console.WriteLine($"Solution: {results[3, 0].result}");
			Console.WriteLine($"Result: {f1(results[3, 0].result)}");
			Console.WriteLine($"Iteration: {results[3, 0].iteration}");
			Console.WriteLine("---------------------------------------------");

			Console.WriteLine("=============================================");

			Console.WriteLine("Simplex Method:");
			Console.WriteLine("Function: 100*(x1^2-x2)^2 + (1-x1)^2");
			Console.WriteLine("Starting point: (-1.2,1)");
			Console.WriteLine($"Solution: {results[0, 1].result}");
			Console.WriteLine($"Result: {f1(results[0, 1].result)}");
			Console.WriteLine($"Iteration: {results[0, 1].iteration}");
			Console.WriteLine("---------------------------------------------");

			Console.WriteLine("Function: 100*(x2-x1^3)^2 + (1-x1)^2");
			Console.WriteLine("Starting point: (-1.2,-1)");
			Console.WriteLine($"Solution: {results[1, 1].result}");
			Console.WriteLine($"Result: {f1(results[1, 1].result)}");
			Console.WriteLine($"Iteration: {results[1, 1].iteration}");
			Console.WriteLine("---------------------------------------------");

			Console.WriteLine("Function: 100*(x1^2-x2)^2 + (1-x1)^2");
			Console.WriteLine("Starting point: (0,0)");
			Console.WriteLine($"Solution: {results[2, 1].result}");
			Console.WriteLine($"Result: {f1(results[2, 1].result)}");
			Console.WriteLine($"Iteration: {results[2, 1].iteration}");
			Console.WriteLine("---------------------------------------------");

			Console.WriteLine("Function: (x1+10*x2)^2 + 5*(x3-x4)^2 + (x2-2*x3)^4 + 10*(x1-x4)^4");
			Console.WriteLine("Starting point: (3,-1,0,1)");
			Console.WriteLine($"Solution: {results[3, 1].result}");
			Console.WriteLine($"Result: {f1(results[3, 1].result)}");
			Console.WriteLine($"Iteration: {results[3, 1].iteration}");
			Console.WriteLine("---------------------------------------------");
		}
    }
}

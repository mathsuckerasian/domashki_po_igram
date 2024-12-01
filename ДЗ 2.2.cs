using System.Diagnostics;
using System.Numerics;

public static class Program {
  public static int GetNumberWithTimeDiffFact(double timediff, int maxValue = 1000)
  {
    timediff *= 1000; //translating to millisecs
    for (var i = 0; i < maxValue; i++) {
      var watch1 = Stopwatch.StartNew();
      RFactorial(i);
      watch1.Stop();
        
      var watch2 = Stopwatch.StartNew();
      Factorial(i);
      watch2.Stop();

      if ((watch1.ElapsedMilliseconds - watch2.ElapsedMilliseconds) > timediff) {
        return i;
      }
    }

    return -1;
  }
  public static int GetNumberWithTimeDiffFib(double timediff, int maxValue = 1000)
  {
    timediff *= 1000; //translating to millisecs
    for (var i = 0; i < maxValue; i++) {
      var watch1 = Stopwatch.StartNew();
      RFibonacci(i);
      watch1.Stop();
        
      var watch2 = Stopwatch.StartNew();
      Fibonacci(i);
      watch2.Stop();

      if ((watch1.ElapsedMilliseconds - watch2.ElapsedMilliseconds) > timediff) {
        return i;
      }
    }
    return -1;
  }
    
  private static BigInteger Factorial(BigInteger n)
  {
    BigInteger res = 1;
    for (BigInteger i = 2; i <= n; i++) {
      res *= i;
    }
    return res;
  }
  private static BigInteger RFactorial(BigInteger n)
  {
    if (n == 0) {
      return 1;
    }
    return RFactorial(n - 1) * n;
  }
  private static BigInteger Fibonacci(BigInteger n)
  {
    BigInteger[] prevs = [1, 1];
    for (BigInteger i = 3; i <= n; i++) {
      var temp = prevs[0] + prevs[1];
      prevs[0] = prevs[1];
      prevs[1] = temp;
    }
    return prevs[1];
  }
  private static BigInteger RFibonacci(BigInteger n)
  {
    if (n <= 2) {
      return 1;
    }

    return RFibonacci(n - 2) + RFibonacci(n - 1);
  }
  
  public static void Main()
  {
    Console.WriteLine("Фибоначчи");
    Console.WriteLine($"Итеративный вариант быстрее рекурсивного на 1 секунду начиная с числа {GetNumberWithTimeDiffFib(1)}");
    Console.WriteLine("Факториал");
    Console.WriteLine($"Итеративный вариант быстрее рекурсивного на 0,1 секунд начиная с числа {GetNumberWithTimeDiffFact(0.01, 100000)}");
  }
}

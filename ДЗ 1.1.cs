public static class Program {
  private static bool IsPrime(int n)
  {
    for (var i = 2; i <= Math.Sqrt(n); i++) {
      if (n % i == 0) {
        return false;
      }
    }
    return true;
  }
  public static void PrintPrimes(int limit) //lab 1.1
  {
    for (var i = 1; i < limit; i++) {
      if (IsPrime(i)) {
        Console.WriteLine(i);
      }
    }
  }
  
  public static void Main()
  {
    Console.Write("Введите число: ");
    PrintPrimes(int.Parse(Console.ReadLine()));
  }
}

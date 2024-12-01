public static class Program {
  public static int CalculateChain(int start) //lab 2.3
  {
    var cnt = 0;
    while (start != 1) {
      cnt++;
      if (start % 2 == 0) {
        start /= 2;
      } else {
        start = 3 * start + 1;
      }
    }
    return cnt;
  }
  
  public static void Main()
  {
    Console.Write("Введите n: ");
    var n = int.Parse(Console.ReadLine());
    Console.WriteLine($"Число замен: {CalculateChain(n)}");
  }
}

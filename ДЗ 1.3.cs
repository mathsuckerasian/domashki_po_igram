public static class Program {
  public static void PrintQuadratic(int a, int b, int c) //lab1.3
  {
    if (a == 0) {
      if (b == 0) {
        Console.WriteLine("Нет корней");
      } else {
        Console.WriteLine($"1 корень: {c / -b}");
      }
      return;
    }
    var d = b * b - 4 * a * c;
    if (d > 0) {
      var root = Math.Sqrt(d);
      Console.WriteLine($"2 корня: {(-b + root) / (a * 2)}, {(-b - root) / (a * 2)}");
      return;
    }
    if (d == 0) {
      Console.WriteLine($"1 корень: {-b / (a * 2)}");
    } else {
      Console.WriteLine("Нет корней");
    }
  }
  
  public static void Main()
  {
    Console.Write("Введите a: ");
    var a = int.Parse(Console.ReadLine());
    Console.Write("Введите b: ");
    var b = int.Parse(Console.ReadLine());
    Console.Write("Введите c: ");
    var c = int.Parse(Console.ReadLine());
    
    PrintQuadratic(a, b, c);
  }
}

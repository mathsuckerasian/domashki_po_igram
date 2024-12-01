public static class Program {
  public static int ReadInt()
  {
    try {
      return int.Parse(Console.ReadLine());
    }
    catch (FormatException e) {
      throw new ArgumentException("This is not a number");
    }
    catch (OverflowException e) {
      throw new ArgumentException("Number is too big");
    }
  }
  public static void Main()
  {
    
  }
}

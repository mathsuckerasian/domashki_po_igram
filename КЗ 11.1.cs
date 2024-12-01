public static class Program {
  public static void PrintSinTable(string filename)
  {
    var writer = new StreamWriter(filename);
    writer.WriteLine("x".PadRight(8) + "sin(x)");

    for (double i = 0; i < 1; i += 0.1) {
      writer.Write(i.ToString("F1").PadRight(8));
      writer.Write(Math.Sin(i).ToString().PadRight(15));
      writer.WriteLine();
    }
    
    writer.Close();
  }
  public static void Main()
  {
    PrintSinTable("./f.txt");
  }
}

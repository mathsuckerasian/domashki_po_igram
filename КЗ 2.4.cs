public static class Program {
  public static void BubbleSort(int[] input)
  {
    var isSorted = false;
    while (!isSorted) {
      isSorted = true;
      for (var i = 0; i < input.Length - 1; i++) {
        if (input[i] > input[i + 1]) {
          (input[i], input[i + 1]) = (input[i + 1], input[i]);
          isSorted = false;
        }
      }
    }
  }
  
  public static void Main()
  {
    Console.Write("Введите элементы массива через пробел: ");
    var strs = Console.ReadLine().Split();
    int[] arr = new int[strs.Length];
    for (var i = 0; i < strs.Length; i++) {
      arr[i] = int.Parse(strs[i]);
    }
    Console.WriteLine("Отсортированный массив:");
    BubbleSort(arr);
    foreach (var elem in arr) {
      Console.Write($"{elem} ");
    }
  }
}

string s = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
Console.Write("Введите слово, которое хотите зашифровать: ");
string input = Console.ReadLine();

foreach (char c in input) {
  Console.Write(s[32 - s.IndexOf(c)]);
}
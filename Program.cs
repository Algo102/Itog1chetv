// Программа выводит только те элементы, у которых количество символов не более определенного
Console.WriteLine("Программа для обработки строчного массива");

//string[] palab = { "Hello", "2", "World", ":-)" };
string[] palab = { "123", "1567", "-2", "computer science" };

string[] palabNew = new string[palab.Length];
for (int i = 0; i < palab.Length; i++) //запись нового массива по заданному условию
  if (palab[i].Length < 4)
  {
    palabNew[i] = palab[i];
  }

for (int i = 0; i < palabNew.Length; i++)
  Console.Write($"{palabNew[i]} ");
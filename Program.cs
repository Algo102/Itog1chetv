// Программа выводит только те элементы, у которых количество символов не более определенного
Console.WriteLine("Программа для обработки строчного массива");

int IntNumber(string mesage)
{
  Console.WriteLine(mesage);
  return int.Parse(Console.ReadLine()!);
}

//string[] palab = { "Hello", "2", "World", ":-)" };
//string[] palab = { "123", "1567", "-2", "computer science" };

int count = IntNumber("Введите количество элементов, которые хотите ввести");
string[] palab = new string[count];
for (int i = 0; i < palab.Length; i++)
{
  Console.Write($"Введите {i + 1} елемент - ");
  palab[i] = Console.ReadLine()!;
}


string[] palabNew = new string[palab.Length];
for (int i = 0; i < palab.Length; i++) //запись нового массива по заданному условию
  if (palab[i].Length < 4)
  {
    palabNew[i] = palab[i];
  }

for (int i = 0; i < palabNew.Length; i++)
  Console.Write($"{palabNew[i]} ");


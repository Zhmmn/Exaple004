// string Metod4(int count, string Text) //принимают данные и возвращают данные
// {

//   string result = string.Empty;
//   for (int i = 0; i < count; i++)
//   {
//     result = result + Text;
//   }
//   return result;

// }
// string result = Metod4(10, "Metod4");
// Console.WriteLine(result);


// for (int i = 2; i <= 10; i++)
// {
//   for (int j = 1; j <= 10; j++)
//   {
//     Console.WriteLine($"{i} x {j} = {i * j}");

//   }
//   Console.WriteLine();
// }

string text = "– Я думаю, – сказал князь, улыбаясь, – что, ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             q0, w1, e2
// s[3] равен r

string Replace(string text, char oldValue, char newValue)
{
  string result = String.Empty;
  int lenght = text.Length;
  for (int i = 0; i < lenght; i++)
  {
    if (text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
  }

  return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
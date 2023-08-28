// Метод который ничего не принимает и не возвращает

// void method1()
// {
//   // Console.WriteLine("Автор Жоомарт");
// }
// method1(); // команда для вызова метода

// void method2(string msg) // что-то принимает, но не возвращает
// {
//   Console.WriteLine(msg);
// }
// // method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//   int i = 0;
//   while (i < count)
//   {
//     Console.WriteLine(msg);
//     i++;
//   }

// }
// Method21(msg: " Текст ", count: 4);

// int Method3() // не принимает данные, но возвращает
// {
//   return DateTime.Now.Year;

// }
// int Year = Method3();
// Console.WriteLine(Year);

string Metod4(int count, string Text) //принимают данные и возвращают данные
{
  int i = 0;
  string result = string.Empty;
  while (i < count)
  {
    result = result + Text;
    i++;

  }
  return result;

}
string result = Metod4(10, "Metod4");
Console.WriteLine(result);
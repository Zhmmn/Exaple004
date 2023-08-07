int[] array = {12,15,18,9,5,55,8,6,3, 55};

int n = array.Length;
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int index = 0;

while (index < n) 
{
  if (array[index] == number)
  {
    Console.WriteLine(index);
    break;
  }
  index++;
}


//Задание №1
Console.Clear();
Console.WriteLine("Задание #1");
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int NaturalNumber(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{NaturalNumber(n, m - 1)}, ");
  return m;
}

int n = Prompt("N: ");
if (n < 1)
{
  Console.WriteLine("Введите положительное число");
  return;
}

int m = Prompt("M: ");
if (m < 1)
{
  Console.WriteLine("Введите положительное число");
  return;
}
if (n>m)
Console.WriteLine("Введите N>M");
else Console.WriteLine(NaturalNumber(n, m));

//Заадание №2
Console.WriteLine("Задание #2");
Console.Write("M: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("N: ");
int b = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(a,b);


void AkkermanFunction(int a, int b)
{
    Console.Write(Akkerman(a, b)); 
}

int Akkerman(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if (b == 0 && a > 0)
    {
        return Akkerman(a - 1, 1);
    }
    else
    {
        return (Akkerman(a - 1, Akkerman(a, b - 1)));
    }
}

//Задание №3
Console.WriteLine("\nЗадание #3");

 void print(int [] Arr, int c) 
    { 
      if (c > 0) 
      { 
      	Console.Write(Arr[c] + " "); 
      	print(Arr, c - 1); 
      } 
      else Console.WriteLine(Arr[0]); 
    } 
    
      int [] num = {2, 3, 5, 550, 100, 3004}; 
      print(num, num.Length - 1); 
    
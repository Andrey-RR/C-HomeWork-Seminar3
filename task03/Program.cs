 //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
  //чисел от 1 до N.
 //  5 -> 1, 8, 27, 64, 125 
 //  3 -> 1, 8, 27 
 //  5 -> 1, 8, 27, 64, 125


int Prompt(string message) 
{
Console.Write(message);
int num = int.Parse(Console.ReadLine());
return num;
}

int count = 1;

void Сube (int num) 
{
while (count <= num)
{
Console.Write(count * count * count + "  ");
count = count + 1;
}
}

int n = Prompt("Введите число N: ");
Сube(n);
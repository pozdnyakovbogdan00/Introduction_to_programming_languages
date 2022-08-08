Console.Write("Inter variable A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("\nInter variable B: ");
int b = int.Parse(Console.ReadLine());
string TextOutPut;

if (a == b*b)
{
   TextOutPut = "Первое число является квадратом второго";
}
else
{
    TextOutPut = "Первое число не является квадратом второго";
}

Console.WriteLine($"\n{TextOutPut}");
Console.Write("Insert N: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = -N;
while (i < N+1)
{
    if (i%2 == 0)
    {
        Console.WriteLine(i);        
    }
    i = i + 1;    
}
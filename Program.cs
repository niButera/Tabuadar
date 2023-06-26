Console.Clear();
Console.Write(@"          --- Tabuada ---      

Digite aqui o número desejado --> ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int m = 0;
int r;


while (m <= 10)
{
    r = n * m;
    Console.WriteLine($"{n} x {m} = {r}");
    m += 1;
}


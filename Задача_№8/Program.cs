Console.WriteLine("Введитe число: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 0;
int num = 1;

while (i < N)
{
    if(num % 2 == 0)
    {
        Console.WriteLine(num);
        num = num + 1;
        i = i + 1;
    }
    else
    {
        num = num + 1;
        i = i + 1;
    }
}

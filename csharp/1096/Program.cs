int i = 1;
int j = 7;

while(i <=9)
{
    for (int k = 0; k < 3; k++)
    {
        Console.WriteLine("I=" + i + " J=" + j);
        j -= 1;
    }
    i += 2;
    j += 3;
}
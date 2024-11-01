int n = int.Parse(Console.ReadLine());
double[] medias = new double[n];

for (int i = 0; i < n; i++)
{
    int j;

    string[] input = Console.ReadLine().Split(' ');
    double[] values = new double[n];
    

    for (j = 0; j < input.Length; j++)
    {
        values[j] = double.Parse(input[j]);

        medias[j] = ((values[0] * 2) + (values[1] * 3) + (values[2] * 5)) / 10;
    } 
}

foreach(var i in medias)
{
    Console.WriteLine(medias);
}

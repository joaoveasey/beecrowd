// necessário importar "System.Collections.Generic"

int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>(n);

for(int i = 0; i < n; i++)
{
    int a = int.Parse(Console.ReadLine());

    list.Add(a);
}

foreach(int valor in list)
{
    string result;

    if (valor % 2 == 0)
        result = "EVEN ";
    else
        result = "ODD ";

    if (valor > 0)
        result = result + "POSITIVE";
    else
        result = result + "NEGATIVE";

    if (valor == 0)
        result = "NULL";

    Console.WriteLine(result);
}
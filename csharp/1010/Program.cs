String[] values1 = Console.ReadLine().Split(' ');
int qtProduct1 = Int16.Parse(values1[1]);
double value1 = Double.Parse(values1[2]);

String[] values2 = Console.ReadLine().Split(' ');
int qtProduct2 = Int16.Parse(values2[1]);
double value2 = Double.Parse(values2[2]);

var total = (qtProduct1 * value1) + (qtProduct2 * value2);

Console.WriteLine(string.Format("VALOR A PAGAR: R$ {0}", total.ToString("0.00")));
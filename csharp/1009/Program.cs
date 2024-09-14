string sellersName = Console.ReadLine();
double fixedSalary = Double.Parse(Console.ReadLine());
double salesTotal = Double.Parse(Console.ReadLine());

double bonus = salesTotal * 0.15;

Console.WriteLine(string.Format("TOTAL = R$ {0}", (fixedSalary + bonus).ToString("0.00")));
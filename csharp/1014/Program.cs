var distance = Int32.Parse(Console.ReadLine());
var km = Double.Parse(Console.ReadLine());

Console.WriteLine(string.Format("{0} km/l", (distance / km).ToString("0.000")));
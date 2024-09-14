double A = Double.Parse(Console.ReadLine());
double B = Double.Parse(Console.ReadLine());
double C = Double.Parse(Console.ReadLine());

double MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 10;

Console.WriteLine(string.Format("MEDIA = {0}", MEDIA.ToString("0.0")));
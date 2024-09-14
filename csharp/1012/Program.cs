String[] values = Console.ReadLine().Split(' ');
var A = double.Parse(values[0]);
var B = double.Parse(values[1]);
var C = double.Parse(values[2]);

Console.WriteLine(string.Format("TRIANGULO: {0}" +
    "\nCIRCULO: {1}" +
    "\nTRAPEZIO: {2}" +
    "\nQUADRADO: {3}" +
    "\nRETANGULO: {4}",
    ((A * C) / 2).ToString("0.000"),
    (3.14159 * Math.Pow(C, 2)).ToString("0.000"),
    (((A + B) * C) / 2).ToString("0.000"),
    (B * B).ToString("0.000"),
    (A * B).ToString("0.000")));
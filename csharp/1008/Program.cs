int ID = Int16.Parse(Console.ReadLine());
int workedHours = Int16.Parse(Console.ReadLine());
double receivedPerHour = Double.Parse(Console.ReadLine());

Console.WriteLine(string.Format("NUMBER = {0}\nSALARY = U$ {1}",
    ID, (workedHours * receivedPerHour).ToString("0.00")));
string numeros = Console.ReadLine();

string[] valores = numeros.Split(' ');

int a = int.Parse(valores[0]);
int b = int.Parse(valores[1]);
int c = int.Parse(valores[2]);

int maiorAB = (a + b + Math.Abs(a - b)) / 2;
int maiorABC = (maiorAB + c + (Math.Abs(maiorAB - c))) / 2;

Console.WriteLine($"{maiorABC} eh o maior");
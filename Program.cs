Console.WriteLine("---Milhas para KM---");
Console.Write("Informe o valor em milhas: ");
string entrada = Console.ReadLine();
double UmaMilhaEmKM = 1.609;
double Milhas = Convert.ToDouble(entrada);
double resultado = Milhas * 1.609;
Console.WriteLine($"{Milhas} milhas em km --> {resultado}");
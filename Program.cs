Console.Write("Digite o consumo do aparelho em KWh/mes: ");
double consumo = double.Parse(Console.ReadLine()!);

Console.Write("Digite o uso do aparelho em horas/dia: ");
double uso = double.Parse(Console.ReadLine()!);

Console.Write("Digite o valor do KWh: ");
double valorKWh = double.Parse(Console.ReadLine()!);

double custoEnergia = consumo * uso * valorKWh;

Console.WriteLine("\n--- Custo de Energia ---");
Console.WriteLine($"Consumo do aparelho: {consumo} KWh/mês");
Console.WriteLine($"Custo da energia (em R$/kWh): {valorKWh}");
Console.WriteLine($"Custo estimado: R${custoEnergia:F2} \n");

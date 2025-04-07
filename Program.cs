double consumomes, horasuso, custohora, custofinal;

Console.WriteLine("Calcule o seu custo de energia de seu aparelho!");
Thread.Sleep(1000);

Console.Write("Digite o consumo do aparelho (em kWh/mês): ");
consumomes = double.Parse(Console.ReadLine()!);

Console.Write("Digite a quantidade de horas de uso por dia: ");
horasuso = double.Parse(Console.ReadLine()!);

Console.Write("Digite o custo de energia (em R$/kWh): ");
custohora = double.Parse(Console.ReadLine()!);

custofinal =  consumomes * horasuso * custohora;

Console.Clear();


Console.WriteLine("--- Custo de Energia ---\n");

Console.WriteLine($"Consumo do aparelho (em kWh/mês)...: {consumomes}");
Console.WriteLine($"Horas de uso por dia...............: {horasuso}");
Console.WriteLine($"Custo da energia (em R$/kWh).......: {custohora}\n");

Console.WriteLine($"Custo estimado.....................: {custofinal:C2}");
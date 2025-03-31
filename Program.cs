
double consumo = 0;
double usoDiario = 0;
double custoEnergia = 0;
double custodoMes = 0;

Console.WriteLine($"Informe o consumo do aparelho (em kWh/mês): ");
consumo = Convert.ToDouble(Console.ReadLine())!;
Console.WriteLine($"Informe o uso diário do aparelho (em horas): ");
usoDiario = Convert.ToDouble(Console.ReadLine())!;
Console.WriteLine($"Informe o custo da energia (em R$/kWh): ");
custoEnergia = Convert.ToDouble(Console.ReadLine())!;

custodoMes = consumo * usoDiario * 30 * custoEnergia;
Console.WriteLine($"O custo mensal do aparelho é: R$ {custodoMes:F2}");

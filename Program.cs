double consumoMensal, custoPorKwh, tempoUsoDiario;

Console.Write("Digite o consumo mensal do aparelho (em kWh).......: ");
while (!double.TryParse(Console.ReadLine()!, out consumoMensal) || consumoMensal <= 0)
{
    Console.Write("Valor inválido. Digite um consumo mensal válido (positivo): ");
}

Console.Write("Digite o custo por kWh (em R$).....................: ");
while (!double.TryParse(Console.ReadLine()!, out custoPorKwh) || custoPorKwh <= 0)
{
    Console.Write("Valor inválido. Digite um custo válido por kWh (positivo): ");
}

Console.Write("Digite o tempo de uso diário do aparelho (em horas): ");
while (!double.TryParse(Console.ReadLine()!, out tempoUsoDiario) || tempoUsoDiario <= 0)
{
    Console.Write("Hora inválida. Digite a hora (positivo) para o tempo de uso diário: ");
}

Console.Clear(); 

double custoMensal = tempoUsoDiario * consumoMensal * custoPorKwh;

Console.WriteLine("Tableas de custos: \n");
Console.WriteLine($"Consumo Mensal.....: {consumoMensal} kWh");
Console.WriteLine($"Custo por kWh......: R$ {custoPorKwh:F2}");
Console.WriteLine($"Tempo de uso diário: {tempoUsoDiario} horas");
Console.WriteLine($"O custo estimado de energia por mês é: R$ {custoMensal:F2}");
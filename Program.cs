double consumoMensal = 17.1, custoPorKwh = 0.62258, tempoUsoDiario; 

Console.Write("Digite o tempo de uso diário do aparelho (em horas): ");

while (!double.TryParse(Console.ReadLine(), out tempoUsoDiario) || tempoUsoDiario <= 0)
    {
        Console.Write("Hora inválida. Digite a hora (positivo) para o tempo de uso diário: ");
    }

double custoMensal = tempoUsoDiario * consumoMensal * custoPorKwh;

Console.WriteLine($"O custo estimado de energia por mês é: R$ {custoMensal:F2}");

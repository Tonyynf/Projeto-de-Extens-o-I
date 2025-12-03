using System;
using System.Collections.Generic;
using System.Linq;

class RegistroDia
{
    public double AguaLitros { get; set; }
    public int HorasSono { get; set; }
    public int Humor { get; set; }
    public string Observacao { get; set; }
}

class Program
{
    static List<RegistroDia> registros = new List<RegistroDia>();

    static void Main()
    {
        int op = 0;
        do
        {
            Console.Clear();

            Console.WriteLine("\n=== HealthyLife - Bem Estar ===");
            Console.WriteLine("1 - Registrar dia");
            Console.WriteLine("2 - Ver relatório semanal");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    RegistrarDia();
                    break;
                case 2:
                    Relatorio();
                    break;
            }

        } while (op != 3);
    }

    static void RegistrarDia()
    {
        Console.Write("Litros de água consumidos: ");
        double agua = double.Parse(Console.ReadLine());

        Console.Write("Horas de sono: ");
        int sono = int.Parse(Console.ReadLine());

        Console.Write("Humor (1 a 5): ");
        int humor = int.Parse(Console.ReadLine());

        Console.Write("Observação: ");
        string obs = Console.ReadLine();

        registros.Add(new RegistroDia
        {
            AguaLitros = agua,
            HorasSono = sono,
            Humor = humor,
            Observacao = obs
        });

        Console.WriteLine("Registro salvo com sucesso!");
    }

    static void Relatorio()
    {
        if (!registros.Any())
        {
            Console.WriteLine("Nenhum registro encontrado!");
            return;
        }

        double mediaAgua = registros.Average(r => r.AguaLitros);
        double mediaSono = registros.Average(r => r.HorasSono);
        double mediaHumor = registros.Average(r => r.Humor);

        Console.WriteLine("\n=== Relatório Semanal ===");
        Console.WriteLine($"Média de água: {mediaAgua:F1} L");
        Console.WriteLine($"Média de sono: {mediaSono:F1} h");
        Console.WriteLine($"Média de humor: {mediaHumor:F1}/5");
    }
}

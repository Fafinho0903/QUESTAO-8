        int votosA = 0;
        int votosB = 0;
        int votosC = 0;
        int votosNulos = 0;
        int voto = -1;

while (voto != 0)
{
    Console.WriteLine("\n OPÇÕES DE VOTO ");
    Console.WriteLine("1: Candidato A");
    Console.WriteLine("2: Candidato B");
    Console.WriteLine("3: Candidato C");
    Console.WriteLine("9: Voto Nulo");
    Console.WriteLine("0: Encerrar a votação e exibir resultados");
    Console.Write("Digite sua opção: ");

    string input = Console.ReadLine();
    if (int.TryParse(input, out int votoDigitado))
    {
        voto = votoDigitado;


        switch (voto)
        {
            case 1:
                votosA++;
                Console.WriteLine("Voto para Candidato A registrado!");
                break;

            case 2:
                votosB++;
                Console.WriteLine("Voto para Candidato B registrado!");
                break;

            case 3:
                votosC++;
                Console.WriteLine("Voto para Candidato C registrado!");
                break;

            case 9:
                votosNulos++;
                Console.WriteLine("Voto Nulo registrado!");
                break;

            case 0:

                Console.WriteLine("Opção 0 selecionada. Encerrando a votação...");
                break;

            default:
                Console.WriteLine("Opção inválida. Por favor, digite 1, 2, 3, 9 ou 0.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
    }
}
        Console.WriteLine("VOTAÇÃO ENCERRADA. RESULTADOS:");
        Console.WriteLine($"Total Candidato A: {votosA} votos");
        Console.WriteLine($"Total Candidato B: {votosB} votos");
        Console.WriteLine($"Total Candidato C: {votosC} votos");
        Console.WriteLine($"Total Votos Nulos: {votosNulos} votos");
    }
}
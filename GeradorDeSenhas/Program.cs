using GerenciadorDeSenhas;

while (true)
{
    Console.WriteLine("+++++++++++++Gerador de Senhas+++++++++++++");
    Console.WriteLine("1 - Gerar senha aleatória");
    Console.WriteLine("2 - Liste as senhas geradas");
    Console.WriteLine("3 - Sair");
    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");

    Console.Write("Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine() ?? "0");


    Gerenciador gerenciador = new Gerenciador(); 


    if (opcao == 1)
    {
        Console.WriteLine("Digite o tamanho da senha: ");
        int tamanhoDaSenha = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Deseja incluir letras maiúsculas? (S/N)");
        bool aceitaMaiusculas = Console.ReadLine().ToUpper() == "S";

        Console.WriteLine("Deseja incluir números? (S/N)");
        bool aceitaNumeros = Console.ReadLine().ToUpper() == "S";

        Console.WriteLine("Deseja incluir caracteres especiais? (S/N)");
        bool aceitaCaracteresEspeciais = Console.ReadLine().ToUpper() == "S";

        string senhaGerada = gerenciador.GerarSenha(tamanhoDaSenha, aceitaMaiusculas, aceitaNumeros, aceitaCaracteresEspeciais);
        Console.WriteLine($"Senha gerada: {senhaGerada}");

        gerenciador.SalvarSenha(senhaGerada);
    }
    else if (opcao == 2)
    {
        List<string> senhasSalvas = gerenciador.LerSenhas();
        if (senhasSalvas.Count > 0)
        {
            Console.WriteLine("Verifique as senhas salvas:");
            foreach (string senha in senhasSalvas)
            {
                Console.WriteLine(senha);
            }
        }
        else
        {
            Console.WriteLine("Nenhuma senha salva");
        }
    }
    else if (opcao == 3)
    {
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }


}

Console.WriteLine("Fim do programa");

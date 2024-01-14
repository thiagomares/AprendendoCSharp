// See https://aka.ms/new-console-template for more information

Dictionary<string, List<int>> alunos = new Dictionary<string, List<int>>();

void insereValores()
{
    Console.WriteLine("Digite o Nome do aluno");
    string nome = Console.ReadLine()!;

    
    List<int> notas = new List<int>();

    for (int i = 0; i < 99; i++)
    {
        Console.WriteLine("Digite as nota do aluno");
        notas.Add(int.Parse(Console.ReadLine()));
        Console.WriteLine("Deseja inserir mais alguma nota? (y/n)");
        char opcao;
        opcao = Console.ReadLine()[0];

        if (opcao == 'n')
        {
            break;
        }
    }
    alunos.Add(nome, notas);
    retornaMedia(nome);
}

void retornaMedia(string nome)
{
    Console.WriteLine($"A média da nota do aluno {nome} é: {alunos[nome].Average()}");
}


insereValores();

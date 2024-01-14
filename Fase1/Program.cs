// Screen Sound

/*
 * Em C#, o tipo de dados é fortemente tipada
 */
 // Isolando Código em funções - Desta forma, nos vamos conseguir reaproveitar codigo

 // List<string> listaDasBandas = new List<string>();
 Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
 
 void ExibirMensagemBoasVindas()
 {
     Console.WriteLine(@"
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
 }

 void ExibirOpcoesMenu()
 {  
     ExibirMensagemBoasVindas();
     Console.WriteLine("Digite 1 para registrar uma banda");
     Console.WriteLine("Digite 2 para mostrar todas as banda");
     Console.WriteLine("Digite 3 para avaliar uma banda");
     Console.WriteLine("Digite 4 para mostrar a média da banda");
     Console.WriteLine("Digite -1 para sair");

     Console.WriteLine("Digite a sua opção: ");
     string opcaoEscolhida = Console.ReadLine()!;

     int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
     switch (opcaoEscolhidaNumerica)
     {
         case 1: RegistrarBandas();
             break;
         case 2: MostraBandas();
             break;
         case 3: AvaliarUmaBanda();
             break;
         case 4: mediaBanda();
             break;
         case -1: Console.WriteLine($"Você digitou para sair" );
             break;
         default: Console.WriteLine("Opção inválida"); Thread.Sleep(2000); Console.Clear(); ExibirOpcoesMenu();
             break;
     }
 }

 void RegistrarBandas()
 {
     Console.Clear();
     ExibirTituloOpcao("Registro Das Bandas");
     Console.Write("Digite a banda a ser registrada: ");
     string nomeDaBanda = Console.ReadLine()!;
     bandasRegistradas.Add(nomeDaBanda, new List<int>());
     Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso ");
     Thread.Sleep(2000);
     Console.Clear();
     ExibirOpcoesMenu();
 }

 void MostraBandas()
 {
     Console.Clear();
     ExibirTituloOpcao("Exibindo todas as bandas registradas");
     foreach (string banda in bandasRegistradas.Keys)
     {
         Console.WriteLine($"Banda: {banda}");
     }

     Console.WriteLine("Pressione uma tecla para continuar");
     Console.ReadKey();
     Thread.Sleep(2000);
     Console.Clear();
     ExibirOpcoesMenu();
 }

 void ExibirTituloOpcao(string titulo)
 {
     int quantidadeLetras = titulo.Length;
     string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
     Console.WriteLine(asteriscos);
     Console.WriteLine(titulo);
     Console.WriteLine(asteriscos + "\n");
 }
 
 void AvaliarUmaBanda()
 {
    Console.Clear();
    ExibirTituloOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda para avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
 }

 void mediaBanda()
 {
     Console.Clear();
     ExibirTituloOpcao("Exibir média da banda");
     Console.WriteLine("Digite a banda");
     string nomeBanda = Console.ReadLine()!;
     if (bandasRegistradas.ContainsKey(nomeBanda))
     {
         Console.WriteLine($"A banda {nomeBanda} tem a média de {bandasRegistradas[nomeBanda].Sum()/bandasRegistradas[nomeBanda].Count}");
         Console.WriteLine("Digite uma tecla para voltar ao menu principal");
         Console.ReadKey();
         Thread.Sleep(2000);
         ExibirOpcoesMenu();
     }
     else
     {
         Console.WriteLine($"A banda {nomeBanda} não foi encontrada");
         Console.WriteLine("Digite uma tecla para sair");
         Console.ReadKey();
         Thread.Sleep(2000);
         Console.Clear();
         ExibirOpcoesMenu();
     }
     
     
 }
 ExibirMensagemBoasVindas();
 ExibirOpcoesMenu();
 
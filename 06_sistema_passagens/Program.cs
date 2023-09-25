class program
{
    public static string[] poltronas = new string[43];

    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo so SesiBus");
        Console.WriteLine("--------------------");
        Console.WriteLine("Contamos com 42 lugares disponivel");

        Menu();
        // string opcao = "2";
        // poltronas[i] = "";
    }

    public static void Menu()
    {

        string opcao = "";

        do
        {
            Console.WriteLine("##### Menu ######");
            Console.WriteLine("1 - para comprar passagem");
            Console.WriteLine("2 - para poltronas disponivel");
            Console.WriteLine("0 - para fechar o sistema");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {

                case "0":
                    Console.WriteLine("Obrigado, volte sempre!!!");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "1":
                    ComprarPassagem();
                    break;
                case "2":
                poltronasDisponiveis();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        } while (opcao != "0");
    }

    public static void ComprarPassagem()

    {
        Console.WriteLine("Quantas passagens deseja comprar");
        int nrPasssagens = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nrPasssagens; i++)
        {
            Console.WriteLine($"Digite a poltrona da {i} Passagem");
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do passageiro");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPoltrona, nome); 

        }
    }

    public static void MarcarPoltrona(int nrPoltrona, string nome)
    {
      poltronas[nrPoltrona] = nome;
    }

    public static void poltronasDisponiveis()
    {
        Console.WriteLine("Lista de poltronas disponivel");
        for (int i = 1; i<= 42; i++)
        {
            if (poltronas[i] == null){
                Console.WriteLine($"Nº {i} ");
            }
        }
    }
}
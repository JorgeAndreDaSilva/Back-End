using ContaBancaria.Model;
// using Microsoft.EntityFrameworkCore;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Seja Bem Vindo a Nosso Sistema");

        Conta();


    }
    public static void Conta()
    {
        Console.WriteLine("Digite o Titular");
        string NomeTitular = (Console.ReadLine());

        ContaCorrente contacorrente1 = new ContaCorrente(NomeTitular);

        string opcao = "";

        do
        {
            Console.WriteLine("Bem Vindo ao Menu");
            Console.WriteLine("Clique em 1 para Mostar Valor de Saldo");
            Console.WriteLine("Clique em 2 para Depositar");
            Console.WriteLine("Clique em 3 para Sacar");            
            Console.WriteLine("Clique em 0 para Fechar o Sistema");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado, volte sempre!!!");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "1":
                    contacorrente1.ConsultarSaldo();
                    break;
                      case "2":
                        Console.WriteLine("Digite o Valor que Deseja Despositar");
                        double ValorS = double.Parse(Console.ReadLine());
                        contacorrente1.DepositarSaldo(ValorS);
                    break;
                     case "3":
                        Console.WriteLine("Digite o Valor que Deseja Sacar");
                        double ValorF = double.Parse(Console.ReadLine());
                        contacorrente1.SacarSaldo(ValorF);
                    break;

                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        } while (opcao != "0");
    }





}


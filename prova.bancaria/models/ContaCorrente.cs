namespace ContaBancaria.Model
{

    public class ContaCorrente
    {
        public string Titular { get; set; }

        private double Saldo { get; set; }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"O valor de saldo é {Saldo}");
        }
        public ContaCorrente(string NomeTitular)
        {
            this.Titular = NomeTitular;
            this.Saldo = 0;

        }
        public void DepositarSaldo(double ValorS)
        {
            if (ValorS == 0)
            {
                Console.WriteLine("Valor não existente");
            }
            else
            {
                Console.WriteLine("Seu valor foi Depositado");
                Saldo += ValorS;

            }

        }
        public void SacarSaldo(double ValorF)
        {
            if (ValorF == 0 || ValorF > Saldo)
            {
                Console.WriteLine("Valor maior que o saldo de sua Conta ");
            }
            else
            {
                Console.WriteLine("Seu valor foi Sacado");
                Saldo -= ValorF;

            }

        }
    }
}
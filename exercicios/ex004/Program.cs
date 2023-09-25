class program
{
    public static void Main()
    {

        int numero = int.Parse(Console.ReadLine());

        double valor = dobro(numero);
        Console.WriteLine($"O Dobro é {valor}");



        int numeroD = int.Parse(Console.ReadLine());

        double valorD = metade(numeroD);
        Console.WriteLine($" A Metade é {valorD}");


        int tabu = int.Parse(Console.ReadLine());
        valorT(tabu);

        ResultadoSalaios();

    }


    public static double dobro(int num)
    {
        double resultado = num + num;
        return resultado;
    }


    public static double metade(int num)
    {
        double resultado = num / 2;
        return resultado;
    }

    public static void valorT(int valor)
    {
        int n = 1;
        while (n <= 10)
        {

            Console.WriteLine(n * valor);
            n++;
       

            System.Threading.Thread.Sleep(500);
        }

    }
    public static void ResultadoSalaios()
    {
        int somaSalarios = 0;
        int menorSalario = 100000;
        int maiorSalario = 0;
        int salarioEmpregado;

        do
        {
                Console.WriteLine("Digite o salario do empregado");
                salarioEmpregado = int.Parse(Console.ReadLine());

                somaSalarios = somaSalarios + salarioEmpregado;
            //  somaSalarios += salarioEmpregado;
            if (salarioEmpregado > maiorSalario)
                {
                    maiorSalario = salarioEmpregado;
                }
            if (salarioEmpregado < maiorSalario && salarioEmpregado > 0)
                    {

                        menorSalario = salarioEmpregado;
                    }
            } while(salarioEmpregado > 0);
            Console.WriteLine($"A soma dos salarios é {somaSalarios} o maior salario é {maiorSalario} o menor salario é {menorSalario}");
        }
}




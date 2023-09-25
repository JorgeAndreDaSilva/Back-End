//fução em JavaScript
//function nomeFuncao (nome){
// }

// public static void nomeFucao (){

// }

class Sesi
{
    public static void Main(){

        // chamando metodo sem retorno
        MostarMensagem("Seja bem vindo");
        MostarMensagem("Sesi / Senai");
        ImprimeDataHora();
        double potencia = potenciacao(4);
        Console.WriteLine($"potenciacao {potencia}");

        ContagemRegressiva(10);
        JogoQueNrSouEu();
    }
    // Metodo sem parametro e sem retorno
    public static double potenciacao(int num){
        double resultado = Math.Pow(num, 2);
        return resultado;
    }
    public static void ImprimeDataHora(){
        Console.WriteLine(DateTime.Now.ToString());
    }
    // metodo com parametro e sem retorno 
    public static void MostarMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    public static void ContagemRegressiva(int n){
        while (n >= 0){
            Console.WriteLine(n);
            n--;
            System.Threading.Thread.Sleep(500);
        }
        Console.WriteLine("BOOOOOMM");
    }

    public static void JogoQueNrSouEu(){
        Console.WriteLine("* * * * * * * * * * * * * ** * * * * * * * * *");
        Console.WriteLine("             Bem Vindos ao Jogo  ");
        Console.WriteLine("Sorteio um Numero de 1 a 20, tente adivinhar");
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * ");
        Console.WriteLine("");
        
        Random rnd = new Random();
        int nrSorteio = rnd.Next(20);
        int nrDigitado = -1;
        
        do {
            Console.WriteLine("Digite um Numero");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteio)
              Console.WriteLine("O numero digitado é maior que o sorteado");
            else if(nrDigitado < nrSorteio)
            Console.WriteLine("O numero digitado é menor que o sorteado");
        } while (nrDigitado != nrSorteio);

        Console.WriteLine("Parabens voce acertou");
    }

}


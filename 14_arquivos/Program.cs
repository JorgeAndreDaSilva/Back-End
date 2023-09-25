using System.IO;

public class Program
{
    public static void Main()
    {
        // gravarAquirvo();
        lerArquivo();
    }
    public static string caminhoArquivo = "arquivos/arquivo.txt";

    public static void lerArquivo()
    {
        try { 
        
        // verificar se o arquivo existe
        if{File.Exists(caminhoArquivo) == false}
        {
            // criando meu arquivo.txt, este comando é executado quando
            // a verificação no if é falsa ou seja o arquivo nao existe
            File.Create(caminhoArquivo);
        }
        using (StreamReader arquivo = new StreamReader(caminhoArquivo))
        {
            string linha;
            while((linha = arquivo.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
        }
        } 
        catch (Exception erro)
        {
      
        }
    }

    public static void gravarAquirvo()
    {
        try
        {
            // Instamciando um objeto da classe StreamWriter para gravar em arquivo
            using (StreamWriter arquivo = new StreamWriter(caminhoArquivo, true))
            {
                Console.WriteLine("Digite seu Texto Para o Arquivo");
                string Texto = Console.ReadLine();
                arquivo.WriteLine($"{Texto}");

            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar a arquivo: {erro.Message}");
        }
    }
}  

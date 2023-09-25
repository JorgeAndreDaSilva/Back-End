public class Program
{
    public static void Main()
    {
        // o Try serve para tratar um erro e não parar a execução do program
        // se ocorrer qualquer erro dentro do bloco try o sistema interrompe a execução do bloco e vai para o catch
        try
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Voçê digitou o Nº {numero}");
            int resultado = 10 / numero;
            Console.WriteLine($"O resultado é {resultado}");
        }
        // tratando execução de Overflow (estouro de campo)
        catch (OverflowException)
        {
            Console.WriteLine("Este numero inteiro é maior que o suportado");
        }
        // tratandoexecução de erro de formato
        catch (FormatException)
        {
            Console.WriteLine($"Erro: Digite um número inteiro");
        }
        // catch é o tratamento de erro, normalmente colocamos as mensagens de acordo
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
        // o finally é o bloco de
        finally
        {
            Console.WriteLine("Entrando no finally");
        }
    }
}
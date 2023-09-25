using Models;


public class Program
{
    public static void Main()
    {
        // criando um objeto da classe pessoa 
        // instanciando sem um metodo construtor 
        /* Pessoa pessoa1 = new Pessoa();
         pessoa1.nome = "Matheus";
         pessoa1.idade = 16;
         pessoa1.Cantar();

         // alternativa para a crianção de um objeto sem construtor
         Pessoa pessoa2 = new Pessoa{
             nome = "Lima",
             idade = 16

         };
         pessoa2.Cantar();
      */
        Pessoa pessoa1 = new Pessoa("Matheus", 16, "matheus.amorim@gmail.com");
        pessoa1.Cantar();
        pessoa1.Email();
        pessoa1.Nasce();

        Pessoa pessoa2 = new Pessoa("Jorge", 26, "Jorge.Andre@gmail.com");
        pessoa2.Cantar();
        pessoa2.Email();
        pessoa2.Nasce();




    }
}
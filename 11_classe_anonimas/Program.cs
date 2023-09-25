public class program
{
    public static void Main()
    {
        // criando uma classe anonima (classe sem definição inicial)
        var pessoa1 = new {
            nome = "João",
            idade = 17
        };
        var pessoa2 = new {
            nome = "maria",
            email = "maria@aluno.senai.br"
        };
        Console.WriteLine($"a pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos");
         Console.WriteLine($"a pessoa2 é {pessoa2.nome} e tem esse email {pessoa2.email}");
  

       var carro1 = new {
            marca = "VW",
            modelo = "gol-quadrado",
            ano = 2001
        };
       var carro2 = new {
            marca = "BMW",
            modelo = "x6",
            ano = 2019
        };
            Console.WriteLine($"Carro1 é um {carro1.modelo} da marca {carro1.marca} e do ano de {carro1.ano}");
            Console.WriteLine($"Carro2 é um {carro2.modelo} da marca {carro2.marca} e do ano de {carro2.ano}");
}
  }
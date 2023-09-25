using System.Collections.Generic;
using Sesi.Models;

public class Program
{

    public static void Main()
    {
        // Criando uma lista de inteiros
        List<int> listaNumeros = new List<int>();

        // adicionando elementos a lista
        listaNumeros.Add(10); //posição [0]
        listaNumeros.Add(20); //posição [1]
        listaNumeros.Add(45); //posição [2]

        // acessando os dados da lista pelo indice 
        Console.WriteLine(listaNumeros[0]);
        Console.WriteLine($"Nesse momento temos tantos {listaNumeros.Count} elementos");

        List<string> listaNomes = new List<string>();
        listaNomes.Add("Suzy");
        listaNomes.Add("Jorge");
        listaNomes.Add("Matheus");

        Console.WriteLine(listaNomes[0]);
        Console.WriteLine(listaNomes[1]);
        Console.WriteLine(listaNomes[2]);
        Console.WriteLine($"Nesse momento temos tantos {listaNomes.Count} elementos");

        //criando uma lista de numeros ja atribuindo valores
        List<int> numeros = new List<int> { 1, 2, 5, 6, 8, 9 };
        Console.WriteLine($"Quantidade de elementos na lista numeros: {numeros.Count}");
        numeros.Remove(1); // vai remover o elemento escolhido
        numeros.RemoveAt(2); // vai remover o elemento do indece escolhido
        numeros.RemoveRange(2, 2); // remover 2 elementos a partir do indece 2

        //subistituindo informação do item da lista 
        numeros[0] = 100;

        // Iterando sobre todos os itens da lista
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }
        foreach (string item in listaNomes)
        {
            Console.WriteLine(item);
        }

        // criando uma lista com objetos da class aluno
        List<aluno> listaAlunos = new List<aluno>();

        //  adicionando um novo aluno a minha lista 
        aluno novoAluno = new aluno("pedro", 16);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new aluno("patricia", 17));
        listaAlunos.Add(new aluno("bob", 17));

        // exibindo lista de alunos
        Console.WriteLine("lista Alunos");

        foreach (aluno item in listaAlunos)
        {
            Console.WriteLine($"O Nome é {item.nome} e a Idade é {item.idade} anos");
        }

        // criando uma nova linha, ordenando por nome  
        var ordenacao = from aluno in listaAlunos
                        where aluno.idade == 17
                        orderby aluno.nome
                        select aluno.nome;

        foreach (var aluno in ordenacao)
        {
            Console.WriteLine(aluno);
        }

        var consulta = listaAlunos
        .where(aluno => aluno.idade == 17)
        .OrderBy(aluno => aluno.nome);
        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }



    }


}

using Sesi.Model;
// using Microsoft.EntityFrameworkCore;

class Program 
{
    public static void Main()
    {
        // criando uma variavel aluno1 e instanciando da classe aluno
        // ou seja estamos criando nosso objeto
        var aluno1 = new Aluno();
        // atribundo um valor ao atribunto nome do aluno
        aluno1.nome = "Jorge";
        aluno1.idade = 17;
        aluno1.turma = "2º EM";
        // Chamando o metodo da classe Aluno
        aluno1.Apresentar();
        
       aluno1.AdicionarFaltas(2);
       aluno1.ResulmirFaltas();
       aluno1.AdicionarFaltas(5);
       aluno1.ResulmirFaltas();
       aluno1.JustificarFaltas(1);
               

        var aluno2 = new Aluno();
        aluno2.nome = "Guilherme Lima";
        aluno2.idade = 16;
        aluno2.turma = "2º EM";
        aluno2.Apresentar();

    }
}


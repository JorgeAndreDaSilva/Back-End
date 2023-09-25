namespace Sesi.Models
{
    public class aluno
    {
        public int idade { get; set; }
        public string nome { get; set; }


        public aluno(string nomeAluno, int idadeAluno)
        {
            this.nome = nomeAluno;
            this.idade = idadeAluno;
        }
        public void Nome()
        {
            Console.WriteLine($"Nome do aluno é {nome} e possui a idade de {idade}");
        }
    }
}
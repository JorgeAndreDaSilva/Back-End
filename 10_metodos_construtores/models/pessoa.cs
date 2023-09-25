namespace Models
{
    public class Pessoa
    {
        // atributos da classe pessoa
        private int idade { get; set; }
        private string nome { get; set; }

        private string email { get; set; }
        private int anoNascimento { get; set; }

        public Pessoa(string nomePessoa, int idadePessoa, string emailPessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anoNascimento = DateTime.Now.Year - idadePessoa; 
        }
        // metodos da classe pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} esta cantando");
        }
        public void Email()
        {
            Console.WriteLine($"O Email de {nome} é {email}");
        }
           public void Nasce()
        {
            Console.WriteLine($"O {nome} nasceu em {anoNascimento}");
        }
    }
}
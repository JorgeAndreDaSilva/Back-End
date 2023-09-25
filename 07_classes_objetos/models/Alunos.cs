// O namespace é um nome em que usaremos para fazer referencia quando usarmos 
// em outras classes
namespace Sesi.Model{
    // declarando nossa classe aluno
    public class Aluno {
        // declarando nosso atributos (propriedade) da classe
        public string nome { get; set; }
        public int idade { get; set; }
         public string turma { get; set; }
         
         private int nrFaltas { get; set; }


        //  criando um metodo 
        public void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anos e estudo na turma {turma}");
        }
        public void AdicionarFaltas(int nr){
            nrFaltas = nrFaltas + nr;
        }
        public void ResulmirFaltas(){
            Console.WriteLine($" {nome} tem {nrFaltas} faltas");
        }
        public void JustificarFaltas(int nr){
            nrFaltas = nrFaltas - nr;
            Console.WriteLine($"Eu fiquei doente e justificou as faltas {nrFaltas}");
        }
        
     
    }
}
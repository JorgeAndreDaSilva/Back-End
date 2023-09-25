
namespace TipoPantera.Model{
    public class Pantera {
  
        public string correr { get; set; }

         public string cacar { get; set; }
         public string reproduzir { get; set;}

         public string peso { get; set; }

         public string especie { get; set;}
         public string cor { get; set; }
         public string tamanho { get; set;}
         
       
        //  criando um metodo 
        public void Correr(){
            Console.WriteLine($"A Partera esta correndo {correr}");
        }
        public void Cacar(){
            Console.WriteLine($"A pantera agorar esta caçando {cacar} ");
        }

        public void reprodu(){
            Console.WriteLine($"A pantera agora esta se reproduzindo {reproduzir}");
        }

        public void ApresentarEspecie(){
            Console.WriteLine($"A Partera é dessa especie {especie}, e ter seu tamanho de {tamanho}, uma cor de {cor} e ter o peso de {peso}");
        }
        
     
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _18_CRUD_BD.Models
{
    // dataAnnotation de como sera criado o nome da tabela no BD
    [Table("Jogos")]
    public class Jogo
    {
        [Key]  //falando para o BD que este atributo sera uma chave 
        public int JogoID { get; set; }
        [Required(ErrorMessage = "Nome é obrigatorio")]
        [MaxLength(200, ErrorMessage = "Descriação pode exceder {1} caracteres")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }

        public bool Ativo { get; set; }



    }
}
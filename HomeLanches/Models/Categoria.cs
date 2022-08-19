using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeLanches.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategriaId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo são 100 caracteres!")]
        [Required(ErrorMessage = "Informe o nome da categoria.")]
        [Display(Name = "Nome da categoria")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres!")]
        [Required(ErrorMessage = "Informe a descrição da categoria.")]
        [Display(Name = "Descrição da categoria")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}

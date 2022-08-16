namespace HomeLanches.Models
{
    public class Categoria
    {
        public int CategriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}

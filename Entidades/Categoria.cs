

namespace ProjetoFimModulo.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Chamado> Chamados { get; set; }
    }
}
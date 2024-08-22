using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis
{
    public class GrupoVeiculos : EntidadeBase
    {
        protected GrupoVeiculos() { }
        public string Nome { get; set; }
        
        public GrupoVeiculos(string nome)
        {
            Nome = nome;
        }
        public override List<string> Validar()
        {
            List<string> erros = [];

            if (Nome.Length < 3)
                erros.Add("O nome é obrigatorio");

            return erros;
        }
    }    
}

using TestePratico_upBase.Domains;

namespace TestePratico_upBase.Interfaces
{
    public interface ITiposUsuarioRepository
    {
        void Cadastrar(TiposUsuario tipoUsuario);

        void Deletar(Guid id);

        List<TiposUsuario> Listar();
    }
}

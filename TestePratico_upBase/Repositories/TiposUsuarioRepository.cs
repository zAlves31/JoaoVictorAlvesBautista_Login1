using TestePratico_upBase.Contexts;
using TestePratico_upBase.Domains;
using TestePratico_upBase.Interfaces;

namespace TestePratico_upBase.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {

        private readonly UpbaseContext _upbaseContext;

        public TiposUsuarioRepository()
        {
            _upbaseContext = new UpbaseContext();
        }

        public void Cadastrar(TiposUsuario tipoUsuario)
        {
            _upbaseContext.TiposUsuario.Add(tipoUsuario);

            _upbaseContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            TiposUsuario tipoBuscado = _upbaseContext.TiposUsuario.Find(id);
            _upbaseContext.TiposUsuario.Remove(tipoBuscado);
            _upbaseContext.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {
            return _upbaseContext.TiposUsuario.ToList(); 
        }
    }
}

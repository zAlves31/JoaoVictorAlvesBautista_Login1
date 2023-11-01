using TestePratico_upBase.Contexts;
using TestePratico_upBase.Domains;
using TestePratico_upBase.Interfaces;

namespace TestePratico_upBase.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly UpbaseContext _upbaseContext;

        public AlunoRepository()
        {
            _upbaseContext = new UpbaseContext();
        }

        public void Atualizar(Guid id, Aluno aluno)
        {
            Aluno alunoBuscado = _upbaseContext.Aluno.Find(id);

            if (alunoBuscado != null)
            {
                alunoBuscado.DataNascimento = aluno.DataNascimento;
                alunoBuscado.Telefone = aluno.Telefone;
                alunoBuscado.RG = aluno.RG;
                alunoBuscado.CPF = aluno.CPF;
                alunoBuscado.Endereco = aluno.Endereco;
            }
            _upbaseContext.Update(alunoBuscado);
            _upbaseContext.SaveChanges();
        }

        public void Cadastrar(Aluno aluno)
        {
            _upbaseContext.Aluno.Add(aluno);
            _upbaseContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Aluno tipoBuscado = _upbaseContext.Aluno.Find(id);
            _upbaseContext.Aluno.Remove(tipoBuscado);
            _upbaseContext.SaveChanges();
        }

        public List<Aluno> Listar()
        {
            return _upbaseContext.Aluno.Select(p => new Aluno
            {
                IdAluno = p.IdAluno,
                DataNascimento = p.DataNascimento,
                Telefone = p.Telefone,
                CPF = p.CPF,
                RG = p.RG,
                Endereco = p.Endereco,

                IdUsuario = p.IdUsuario,
                Usuario = new Usuario
                {
                    IdUsuario = p.IdUsuario,
                    Nome = p.Usuario!.Nome,
                    Email = p.Usuario!.Email,
                    Senha = p.Usuario!.Senha,
                    IdTipoUsuario = p.Usuario!.IdTipoUsuario,

                    TiposUsuario = new TiposUsuario
                    {
                        IdTipoUsuario = p.Usuario.IdTipoUsuario,
                        Titulo = p.Usuario.TiposUsuario!.Titulo
                    }
                }
            }).ToList();

        }
    }
}

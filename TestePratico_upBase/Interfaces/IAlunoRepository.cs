using TestePratico_upBase.Domains;

namespace TestePratico_upBase.Interfaces
{
    public interface IAlunoRepository
    {
        void Cadastrar(Aluno aluno);

        void Deletar(Guid id);

        void Atualizar(Guid id, Aluno aluno);

        List<Aluno> Listar();
    }
}

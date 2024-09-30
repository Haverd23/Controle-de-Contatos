using Estados.Models;

namespace Estados.Repositorio
{
    public interface IEstadoRepositorio
    {
        List<EstadoModel> BuscarTodos();
        EstadoModel BuscarPorId(int id);
        EstadoModel Criar(EstadoModel estado);
        EstadoModel Atualizar (EstadoModel estado);
        bool Apagar(int id);

        EstadoModel BuscarPorLogin(string login);



    }
}

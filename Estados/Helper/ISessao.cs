using Estados.Models;

namespace Estados.Helper
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario(EstadoModel estado);
        void RemoverSessaoDoUsuario();
        EstadoModel BuscarSessaoDoUsuario();
    }
}

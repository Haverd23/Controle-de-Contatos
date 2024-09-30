using Estados.Data;
using Estados.Models;

namespace Estados.Repositorio
{
    public class EstadoRepositorio : IEstadoRepositorio
    {
        private readonly EstadoContext _estadoContext;
        public EstadoRepositorio(EstadoContext estadoContext)
        {
            _estadoContext = estadoContext;
        }

        public bool Apagar(int id)
        {
            EstadoModel estado = BuscarPorId(id);
            if (estado == null) throw new Exception("Esse usuário não existe");
            _estadoContext.Remove(estado);
            _estadoContext.SaveChanges();
            return true;
        }

        public EstadoModel Atualizar(EstadoModel estado)
        {
            ;
            EstadoModel estadoDb = BuscarPorId(estado.Id);
            if (estadoDb == null) throw new Exception("Esse usuário não existe");
            estadoDb.Name = estado.Name;
            estadoDb.Idade = estado.Idade;
            estadoDb.Perfil = estado.Perfil;
            estadoDb.Estado = estado.Estado;
            estadoDb.Cidade = estado.Cidade;
            estadoDb.DataAtualizacao =DateTime.Now;
            _estadoContext.Update(estadoDb);
            _estadoContext.SaveChanges();
            return estadoDb;
        }

        public EstadoModel BuscarPorId(int id)
        {
            return _estadoContext.Estados.FirstOrDefault(x => x.Id == id);
        }

        public List<EstadoModel> BuscarTodos()
        {
            return _estadoContext.Estados.ToList();
        }

        public EstadoModel Criar(EstadoModel estado)
        {
            estado.DataCadastro = DateTime.Now;
            estado.SetSenhaHash();
            _estadoContext.Add(estado);
            _estadoContext.SaveChanges();
            return estado;
        }

        public EstadoModel BuscarPorLogin(string login)
        {
            return _estadoContext.Estados.FirstOrDefault(x => x.Login.ToUpper() == login.ToUpper());
        }
    }
}

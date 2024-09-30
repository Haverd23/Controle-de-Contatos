using Estados.Models;
using Newtonsoft.Json;

namespace Estados.Helper
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public Sessao(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        public EstadoModel BuscarSessaoDoUsuario()
        {
            string sesassaoUsuario = _contextAccessor.HttpContext.Session.GetString("sessaoUsuarioLogado");
            if (string.IsNullOrEmpty(sesassaoUsuario)) return null;
            return JsonConvert.DeserializeObject<EstadoModel>(sesassaoUsuario);
        }

        public void CriarSessaoDoUsuario(EstadoModel estado)
        {
            string valor = JsonConvert.SerializeObject(estado);

            _contextAccessor.HttpContext.Session.SetString("sessaoUsuarioLogado", valor);
        }

        public void RemoverSessaoDoUsuario()
        {
            _contextAccessor.HttpContext.Session.Remove("sessaoUsuarioLogado");
        }
    }
}

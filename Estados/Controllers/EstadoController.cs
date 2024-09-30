using Estados.Filters;
using Estados.Models;
using Estados.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Estados.Controllers
{
    
    public class EstadoController : Controller
    {
        private readonly IEstadoRepositorio _estadoRepositorio;
        public EstadoController(IEstadoRepositorio estadoRepositorio)
        {
            _estadoRepositorio = estadoRepositorio;
        }

        [PaginaParaUsuarioLogado]
        public IActionResult Index()
        {
            var home = _estadoRepositorio.BuscarTodos();
            return View(home);
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(EstadoModel estadoModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _estadoRepositorio.Criar(estadoModel);
                    TempData["MensagemSucesso"] = "Contato Cadastrado com Sucesso";
                    return RedirectToAction("Index");
                }
                return View(estadoModel);
            }
            catch (Exception ex)
            {
                TempData["MenssagemErro"] = $"Não foi possível criar cadastro erro: {ex.Message}";
                return RedirectToAction("Index");
            }

        }
        [PaginaParaUsuarioLogado]
        public IActionResult Editar(int id)
        {
            EstadoModel estado = _estadoRepositorio.BuscarPorId(id);
            return View(estado);
        }
        [HttpPost]
        public IActionResult Alterar(EstadoSemSenha semSenha)
        {
            try
            {
                EstadoModel estado = null;
                if (ModelState.IsValid)
                {
                    estado = new EstadoModel()
                    {
                        Id = semSenha.Id,
                        Name = semSenha.Name,
                        Idade = semSenha.Idade,
                        Perfil = semSenha.Perfil,
                        Estado = semSenha.Estado,
                        Cidade = semSenha.Cidade
                    };
                    estado = _estadoRepositorio.Atualizar(estado);
                    TempData["MenssagemSucesso"] = "Estado Atualizado com Sucesso";
                    return RedirectToAction("Index");
                }
                return View("Editar", estado);

            }
            catch (Exception ex)
            {
                TempData["MenssagemErro"] = $"Não foi alterar criar cadastro erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }
        [PaginaParaUsuarioLogado]
        public IActionResult ApagarConfirmacao(int id)
        {
            EstadoModel estado = _estadoRepositorio.BuscarPorId(id);
            return View(estado);
        }
        [PaginaParaUsuarioLogado]
        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _estadoRepositorio.Apagar(id);
                if (apagado) TempData["MensagemSucesso"] = "Usuario apagado com sucesso!"; else TempData["MensagemErro"] = "Ops, não conseguimos cadastrar seu usuario, tente novamante!";
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu usuario, tente novamante, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}

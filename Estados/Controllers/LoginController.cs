
using Estados.Models;
using Estados.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Estados.Helper;

namespace Estados.Controllers
{
    public class LoginController : Controller
    {
        private readonly IEstadoRepositorio _usuarioRepositorio;
        private readonly ISessao _sessao;


        public LoginController(IEstadoRepositorio usuarioRepositorio,
                               ISessao sessao )
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
          
        }

        public IActionResult Index()
        {
            if(_sessao.BuscarSessaoDoUsuario() != null) return RedirectToAction("Index", "Home");
            return View();

        }




        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EstadoModel usuario = _usuarioRepositorio.BuscarPorLogin(loginModel.Login);

                    if (usuario != null)
                    {   _sessao.CriarSessaoDoUsuario(usuario);
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                           
                            return RedirectToAction("Index", "Home");
                        }

                        TempData["MensagemErro"] = $"Senha do usuário é inválida, tente novamente.";
                    }

                    TempData["MensagemErro"] = $"Usuário e/ou senha inválido(s). Por favor, tente novamente.";
                }

                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamante, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Sair()
        {
            _sessao.RemoverSessaoDoUsuario();
            return RedirectToAction("Index", "Login");
        }
     
    }
}

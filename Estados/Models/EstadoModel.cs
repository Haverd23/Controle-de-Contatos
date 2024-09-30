using ControleDeContatos.Helper;
using Estados.Enums;
using System.ComponentModel.DataAnnotations;

namespace Estados.Models
{
    public class EstadoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Digite seu nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Digite sua idade")]
        public int Idade { get; set; }
        [Required(ErrorMessage = "Digite um login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite uma senha")]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        [Required(ErrorMessage = "Escolha um tipo de perfil")]
        public PerfilEnum? Perfil { get; set; }
        [Required(ErrorMessage = "Digite seu Estado")]
        public EstadoEnum? Estado { get; set; }
        [Required(ErrorMessage = "Digite sua Cidade")]
        public string Cidade { get; set; }

        public bool SenhaValida(string senha)
        {
            return Senha == senha.GerarHash();
        }

        public void SetSenhaHash()
        {
            Senha = Senha.GerarHash();
        }


    }
}

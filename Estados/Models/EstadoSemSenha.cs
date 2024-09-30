using Estados.Enums;
using System.ComponentModel.DataAnnotations;

namespace Estados.Models
{
    public class EstadoSemSenha
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite seu nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Digite sua idade")]
        public int Idade { get; set; }
        [Required(ErrorMessage = "Digite seu perfil")]
        public PerfilEnum Perfil { get; set; }
        [Required(ErrorMessage = "Digite seu Estado")]
        public EstadoEnum Estado { get; set; }
        [Required(ErrorMessage = "Digite sua Cidade")]
        public string Cidade { get; set; }
    }
}

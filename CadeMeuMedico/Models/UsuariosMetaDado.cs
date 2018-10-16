using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    public class UsuariosMetaDado
    {
        public long IDUsuario { get; set; }

        [Required(ErrorMessage = "Seu Nome é Obrigatório")]
        [StringLength(80, ErrorMessage ="Tamanho máximo de 80 catacteres para o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Informe o login que deseja")]
        [StringLength(30, ErrorMessage ="tamanho máximo de 30 caracteres para o login")]
        public string Login { get; set; }

        [Required(ErrorMessage ="Informe a senha que deseja")]
        [StringLength(100, ErrorMessage ="tamanho máximo de 100 caracteres para a senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage ="Informe o seu e-mail")]
        [StringLength(100, ErrorMessage ="tamanho maximo de 100 caracteres para o email")]
        public string Email { get; set; }
    }
}
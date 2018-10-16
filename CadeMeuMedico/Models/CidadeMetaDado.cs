using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    public class CidadeMetaDado
    {
       
        public int IDCidade { get; set; }

        [Required(ErrorMessage = "Campo nome da cidade é obrigatório")]
        [StringLength(100, ErrorMessage ="tamaho máximo do nome da cidade é 100 caracteres")]
        public string Nome { get; set; }
    }
}
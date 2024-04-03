using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeCadastro.Domain.Entities.Cadastro
{
    public class tPessoaFisica
    {
        [Key]
        public int IdPessoaFisica { get; set; }

        [Required]
        [ForeignKey("Id")]
        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "Informar o CPF da pessoa!")]
        public string CPF { get; set; }
    }
}

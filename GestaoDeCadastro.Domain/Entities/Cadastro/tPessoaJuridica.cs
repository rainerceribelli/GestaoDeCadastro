using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeCadastro.Domain.Entities.Cadastro
{
    public class tPessoaJuridica
    {
        [Key]
        public int IdPessoaJuridica { get; set; }

        [Required]
        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "Informar o CNPJ!")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Informar Razão Social!")]
        public string RazaoSocial { get; set; }
    }
}

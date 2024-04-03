using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeCadastro.Domain.Entities.Cadastro
{
    public class tPessoa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencher o tipo da pessoa!")]
        public int Tipo { get; set; }

        [Required(ErrorMessage = "Informar o nome da pessoa!")]
        public string Nome { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public string Telefone { get; set; }

        public bool BitAtivo { get; set; }

        [ForeignKey("IdPessoa")]
        public ICollection<tPessoaFisica> PessoaFisica { get; set; }

        [ForeignKey("IdPessoa")]
        public ICollection<tPessoaJuridica> PessoaJuridica { get; set; }
    }
}

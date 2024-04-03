using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeCadastro.Crosscutting.DTO.Cadastro
{
    public class CreatePessoaDTO
    {
        public int Tipo { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public string CPF { get; set; }

        public string CNPJ { get; set; }

        public string RazaoSocial { get; set; }

        public bool BitAtivo { get; set; }
    }
}

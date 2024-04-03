using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeCadastro.Crosscutting.DTO.Cadastro
{
    public class CreatePessoaJuridicaDTO
    {
        public int IdPessoa { get; set; }

        public string CNPJ { get; set; }

        public string RazaoSocial { get; set; }
    }
}

using GestaoDeCadastro.Crosscutting.Attributes;
using GestaoDeCadastro.Crosscutting.DTO.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeCadastro.Crosscutting.Enum.Cadastro
{
    public class TipoCadastroPessoa
    {
        public enum TipoCadastroPessoaEnum
        {
            [EnumInfos(Title = "Fisica")]
            Fisica = 1,

            [EnumInfos(Title = "Juridica")]
            Juridica = 2
        }

    }
}

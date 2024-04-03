using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeCadastro.Crosscutting.Attributes
{
    public class EnumInfosAttribute : Attribute
    {
        public string Title { get; set; }

        public EnumInfosAttribute(string _Title = null)
        {
            Title = _Title;
        }
    }
}

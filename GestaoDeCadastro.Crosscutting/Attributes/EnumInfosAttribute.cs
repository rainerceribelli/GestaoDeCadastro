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

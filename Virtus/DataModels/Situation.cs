using System.ComponentModel;

namespace Virtus
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Situation
    {
        [Description("Cadastro Ativo")]
        Ativo = 0,

        [Description("Cadastro Inativo")]
        Inativo = 1
    }
}

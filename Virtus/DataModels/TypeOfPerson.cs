using System.ComponentModel;

namespace Virtus
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum TypeOfPerson
    {
        [Description("Pessoa Física")]
        Fisica = 0,

        [Description("Pessoa Jurídica")]
        Juridica = 1
    }
}

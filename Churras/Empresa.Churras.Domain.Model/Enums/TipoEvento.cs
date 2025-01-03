namespace Empresa.Churras.Domain.Model.Enums;

using System.ComponentModel.DataNotations;

public enum TipoEvento
{
    [Description("Churrasco")]
    Churras,

    [Description("Pizza")]
    Pizza,

    [Description("Lanche")]
    Lanche,

    [Description("Outros")]
    Outros
}
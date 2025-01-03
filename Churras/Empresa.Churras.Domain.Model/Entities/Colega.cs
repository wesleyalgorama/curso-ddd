namespace Empresa.Churras.Domain.Model.Entities;

using Kernel.Domain.Model.Entities;

public class Colega : EntityKeySeq
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
}
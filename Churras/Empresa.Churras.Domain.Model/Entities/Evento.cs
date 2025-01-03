namespace Empresa.Churras.Domain.Model.Entities;

using Kernel.Domain.Model.Entities;
using Empresa.Churras.Domain.Model.ValueObjects;
using Empresa.Churras.Domain.Model.Enums;

public class Evento : EntityKeySeq
{
    public long DonoCasaId { get; set; }
    public Colega DonoCasa { get; set; }
    public TipoEvento TipoEvento { get; set; }
    public DateTime Dia { get; set; }
    public Periodo Periodo { get; set; }
    public IList<EventoColega> ColegasConfirmados { get; set; }
}
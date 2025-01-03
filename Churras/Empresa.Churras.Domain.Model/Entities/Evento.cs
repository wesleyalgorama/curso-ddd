namespace Empresa.Churras.Domain.Model.Entities;

using Kernel.Domain.Model.Entities;
using Empresa.Churras.Domain.Model.ValueObjects;
using Empresa.Churras.Domain.Model.Enums;

public class Evento : EntityKeySeq
{
    public long DonoCasaId { get; set; }
    public Colega DonoCasa { get; set; }
    public TipoEvento TipoEvento { get; set; }
    public string Nome { get; set; }
    public DateTime Dia { get; set; }
    public Periodo Periodo { get; set; }
    public IList<EventoColega> ColegasConfirmados { get; set; }

    public void ConfirmarPresenca(Colega colega)
    {
        if (ColegasConfirmados == null)
            ColegasConfirmados = new List<EventoColega>();

        ColegasConfirmados.Add(new EventoColega
        {
            ColegaId = 1,
            ColegaNome = "Tiao",
            OQueVaiLevar = "Carne"
        })
    }

    public void CancelarPresenca(Colega colega)
    {
        if (ColegasConfirmados == null) return;

        var confirmacao = ColegasConfirmados.FirstOrDefault(x => x.Id == colega.Id);

        if (confirmacao != null)
            ColegasConfirmados.Remove(colega);
    }
}

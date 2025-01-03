namespace Empresa.Churras.Tests.Entities;

public class EventoTest : IAsyncLifetime
{
    [Fact]
    public void ConfirmarPresenca_Test()
    {
        var colega = new Colega
        {
            Id = 1,
            Nome = "Tiao"
        };

        var evento = new Evento
        {
            Id = 1,
            Nome = "Churras da Firma"
        };

        evento.ConfirmarPresenca(colega);
        var confirmacao = evento.ColegasConfirmados.FirstOrDefault();

        Assert.IsNotNull(confirmacao);
        Assert.Equal(colega.Id, confirmacao.Id);
    }

    [Fact]
    public void CancelarPresenca_Test()
    {
        var colega = new Colega
        {
            Id = 1,
            Nome = "Tiao"
        };

        var evento = new Evento
        {
            Id = 1,
            Nome = "Churras da Firma"
        };

        evento.ConfirmarPresenca(colega);
        var confirmacao = evento.ColegasConfirmados.FirstOrDefault();

        Assert.IsNull(confirmacao);
    }
}
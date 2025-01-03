namespace Empresa.Churras.Tests.ValueObjects;

public class PeriodoTest : IAsyncLifetime
{
    [Fact]
    public void QuantoDuraEmHoras_Test()
    {
        var periodo = new Periodo
        {
            Inicio = new DateTime(2025, 1, 12, 0, 0),
            Fim = new DateTime(2025, 1, 1, 18, 0, 0)
        };

        var horas = periodo.QuantoDuraEmHoras();
        Assert.Equal(6, horas);
    }

    [Fact]
    public void QuantoHorasFaltamParaComecar_Test()
    {
        var periodo = new Periodo
        {
            Inicio = new DateTime(2025, 1, 12, 0, 0),
            Fim = new DateTime(2025, 1, 1, 18, 0, 0)
        };

        var horas = periodo.uantoHorasFaltamParaComecar();
        Assert.Equal(6, horas);
    }
}
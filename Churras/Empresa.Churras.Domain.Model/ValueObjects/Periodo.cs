namespace Empresa.Churras.Domain.Model.ValueObjects;

using System;
using System.Collections.Generic;

public class Periodo : ValueObjects
{
    public DateTime Inicio { get; set; }
    public DateTime Fim { get; set; }

    public int QuantoDuraEmHoras()
    {
        var duracao = GetDuracao();
        return duracao.Hours;
    }

    public int QuantoHorasFaltamParaComecar()
    {
        if (Inicio < DateTime.Now)
            return -1;

        var duracao = Inicio.Subtract(DateTime.Now);

        return duracao.Hours;
    }

    private int GetDuracao()
    {
        return Fim.Subtract(Inicio);
    }
}

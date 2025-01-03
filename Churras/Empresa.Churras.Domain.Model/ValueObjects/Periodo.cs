namespace Empresa.Churras.Domain.Model.ValueObjects;

using System;
using System.Collections.Generic;

public class Periodo : ValueObjects
{
    public DateTime Inicio { get; set; }
    public DateTime Fim { get; set; }
}

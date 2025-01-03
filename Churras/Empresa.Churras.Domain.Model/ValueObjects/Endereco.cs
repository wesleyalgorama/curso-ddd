namespace Empresa.Churras.Domain.Model.ValueObjects;

using System;
using System.Collections.Generic;

public class Endereco : ValueObjects
{
    public string Cep { get; set; }
    public string Logadouro { get; set; }
    public short Numero { get; set; }
    public string Bairro { get; set; }
    public string Complemento { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public Coordenadas coordenadas { get; set; }
}

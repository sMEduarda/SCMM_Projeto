using System;
using System.Collections.Generic;

namespace SCMM_Projeto.Models;

public partial class Materiai
{
    public int IdMaterial { get; set; }

    public string? NomeMaterial { get; set; }

    public int? Quantidade { get; set; }

    public string? Unidade { get; set; }

    public virtual ICollection<Solicitaco> Solicitacos { get; set; } = new List<Solicitaco>();
}

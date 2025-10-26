using System;
using System.Collections.Generic;

namespace SCMM_Projeto.Models;

public partial class Solicitaco
{
    public int IdSolicitacao { get; set; }

    public DateTime? DataSolicitacao { get; set; }

    public string? Solicitante { get; set; }

    public int? IdMaterial { get; set; }

    public int? QuantidadeSolicitada { get; set; }

    public string? Status { get; set; }

    public virtual Materiai? IdMaterialNavigation { get; set; }
}

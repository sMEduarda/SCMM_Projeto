using System;
using System.Collections.Generic;

namespace SCMM_Projeto.Models;

public partial class OrdemServico
{
    public int IdOs { get; set; }

    public string? NumeroOs { get; set; }

    public string? Responsavel { get; set; }

    public DateTime? DataAbertura { get; set; }

    public string? Status { get; set; }
}

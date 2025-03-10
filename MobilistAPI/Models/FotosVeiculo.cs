using System;
using System.Collections.Generic;

namespace MobilistAPI.Models;

public partial class FotosVeiculo
{
    public int Id { get; set; }

    public int? IdLado { get; set; }

    public string? FileName { get; set; }

    public int? IdChecklist { get; set; }

    public virtual Checklist? IdChecklistNavigation { get; set; }

    public virtual Lado? IdLadoNavigation { get; set; }
}

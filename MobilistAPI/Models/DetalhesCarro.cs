using System;
using System.Collections.Generic;

namespace MobilistAPI.Models;

public partial class DetalhesCarro
{
    public int Id { get; set; }

    public int? IdChecklist { get; set; }

    public string? FileName { get; set; }

    public string? Descricao { get; set; }

    public virtual Checklist? IdChecklistNavigation { get; set; }
}

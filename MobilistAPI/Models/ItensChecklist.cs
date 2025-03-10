using System;
using System.Collections.Generic;

namespace MobilistAPI.Models;

public partial class ItensChecklist
{
    public int Id { get; set; }

    public int? IdItem { get; set; }

    public int? IdChecklist { get; set; }

    public bool? Possui { get; set; }

    public virtual Checklist? IdChecklistNavigation { get; set; }

    public virtual Iten? IdItemNavigation { get; set; }
}

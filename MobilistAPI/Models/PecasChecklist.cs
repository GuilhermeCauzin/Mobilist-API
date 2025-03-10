using System;
using System.Collections.Generic;

namespace MobilistAPI.Models;

public partial class PecasChecklist
{
    public int Id { get; set; }

    public int? IdPeca { get; set; }

    public int? IdChecklist { get; set; }

    public int? Situacao { get; set; }

    public virtual Checklist? IdChecklistNavigation { get; set; }

    public virtual Peca? IdPecaNavigation { get; set; }
}

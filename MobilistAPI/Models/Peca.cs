using System;
using System.Collections.Generic;

namespace MobilistAPI.Models;

public partial class Peca
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<PecasChecklist> PecasChecklists { get; set; } = new List<PecasChecklist>();
}

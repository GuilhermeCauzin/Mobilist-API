using System;
using System.Collections.Generic;

namespace MobilistAPI.Models;

public partial class Iten
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<ItensChecklist> ItensChecklists { get; set; } = new List<ItensChecklist>();
}

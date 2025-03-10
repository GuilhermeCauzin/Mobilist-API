using System;
using System.Collections.Generic;

namespace MobilistAPI.Models;

public partial class Lado
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<FotosVeiculo> FotosVeiculos { get; set; } = new List<FotosVeiculo>();
}

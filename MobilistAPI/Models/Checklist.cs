using System;
using System.Collections.Generic;

namespace MobilistAPI.Models;

public partial class Checklist
{
    public int Id { get; set; }

    public int? IdFuncionario { get; set; }

    public string? MarcaModelo { get; set; }

    public string? Placa { get; set; }

    public string? Ano { get; set; }

    public string? Cor { get; set; }

    public string? Quilometragem { get; set; }

    public double? NivelCombustivel { get; set; }

    public string? NomeMotorista { get; set; }

    public string? TelefoneMotorista { get; set; }

    public string? Observações { get; set; }

    public DateTime? DataHora { get; set; }

    public virtual ICollection<DetalhesCarro> DetalhesCarros { get; set; } = new List<DetalhesCarro>();

    public virtual ICollection<FotosVeiculo> FotosVeiculos { get; set; } = new List<FotosVeiculo>();

    public virtual ICollection<ItensChecklist> ItensChecklists { get; set; } = new List<ItensChecklist>();

    public virtual ICollection<PecasChecklist> PecasChecklists { get; set; } = new List<PecasChecklist>();
}

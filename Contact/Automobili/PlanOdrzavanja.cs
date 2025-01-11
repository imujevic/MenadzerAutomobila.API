namespace Contract;

public class PlanOdrzavanjaDto
{
    public string Id { get; set; }

    public string AutomobilId { get; set; }

    public DateTime DatumOdrzavanja { get; set; }

    public string Opis { get; set; } = string.Empty;

    public decimal Cena { get; set; }
}

public class CreatePlanOdrzavanjaDto
{
    public string AutomobilId { get; set; }

    public DateTime DatumOdrzavanja { get; set; }

    public string Opis { get; set; } = string.Empty;

    public decimal Cena { get; set; }
}

public class UpdatePlanOdrzavanjaDto
{
    public string Id { get; set; }

    public string AutomobilId { get; set; }

    public DateTime DatumOdrzavanja { get; set; }

    public string Opis { get; set; } = string.Empty;

    public decimal Cena { get; set; }
}

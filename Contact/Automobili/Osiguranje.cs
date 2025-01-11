namespace Contract;

public class OsiguranjeDto
{
    public string Id { get; set; }

    public string AutomobilId { get; set; }

    public string NazivOsiguravajuceKuce { get; set; } = string.Empty;

    public decimal IznosPolise { get; set; }

    public DateTime DatumPocetka { get; set; }

    public DateTime DatumIsteka { get; set; }
}

public class CreateOsiguranjeDto
{
    public string AutomobilId { get; set; }

    public string NazivOsiguravajuceKuce { get; set; } = string.Empty;

    public decimal IznosPolise { get; set; }

    public DateTime DatumPocetka { get; set; }

    public DateTime DatumIsteka { get; set; }
}

public class UpdateOsiguranjeDto
{
    public string Id { get; set; }

    public string AutomobilId { get; set; }

    public string NazivOsiguravajuceKuce { get; set; } = string.Empty;

    public decimal IznosPolise { get; set; }

    public DateTime DatumPocetka { get; set; }

    public DateTime DatumIsteka { get; set; }
}

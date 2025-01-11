namespace Contract;

public class AutomobilDto
{
    public string Id { get; set; }

    public string Marka { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public int GodinaProizvodnje { get; set; }

    public string? RegistracijskiBroj { get; set; }

    public string? Boja { get; set; }

    public string? BrojSasije { get; set; }

    public decimal Cijena { get; set; }

    public string? VlasnikId { get; set; }
}

public class CreateAutomobilDto
{
    public string Marka { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public int GodinaProizvodnje { get; set; }

    public string? RegistracijskiBroj { get; set; }

    public string? Boja { get; set; }

    public string? BrojSasije { get; set; }

    public decimal Cijena { get; set; }

    public string? VlasnikId { get; set; }
}

public class UpdateAutomobilDto
{
    public string Id { get; set; }

    public string Marka { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public int GodinaProizvodnje { get; set; }

    public string? RegistracijskiBroj { get; set; }

    public string? Boja { get; set; }

    public string? BrojSasije { get; set; }

    public decimal Cijena { get; set; }

    public string? VlasnikId { get; set; }
}

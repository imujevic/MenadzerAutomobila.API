namespace Contract;

public class KreditDto
{
    public string Id { get; set; }

    public string KorisnikId { get; set; }

    public decimal Iznos { get; set; }

    public decimal KamatnaStopa { get; set; }

    public int BrojGodina { get; set; }

    public DateTime DatumPocetka { get; set; }

    public DateTime? DatumZavrsetka { get; set; }
}

public class CreateKreditDto
{
    public string KorisnikId { get; set; }

    public decimal Iznos { get; set; }

    public decimal KamatnaStopa { get; set; }

    public int BrojGodina { get; set; }

    public DateTime DatumPocetka { get; set; }
}

public class UpdateKreditDto
{
    public string Id { get; set; }

    public decimal Iznos { get; set; }

    public decimal KamatnaStopa { get; set; }

    public int BrojGodina { get; set; }

    public DateTime DatumPocetka { get; set; }

    public DateTime? DatumZavrsetka { get; set; }
}

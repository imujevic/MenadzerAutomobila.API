namespace Contract;

public class KorisnikDto
{
    public string Id { get; set; }

    public string Ime { get; set; } = string.Empty;

    public string? Prezime { get; set; }

    public string? Email { get; set; }

    public string? PasswordResetToken { get; set; }

    public string? EmailConfirmationToken { get; set; }

    public string RefreshToken { get; set; } = string.Empty;

    public DateTime RefreshTokenExpiryTime { get; set; }

    public string? BrojTelefona { get; set; }

    public List<string> Roles { get; } = [];
}

public class KorisnikCreateDto
{
    public string Ime { get; set; } = string.Empty;

    public string? Prezime { get; set; }

    public string? Email { get; set; }

    public string? PasswordResetToken { get; set; }

    public string? EmailConfirmationToken { get; set; }

    public string RefreshToken { get; set; } = string.Empty;

    public DateTime RefreshTokenExpiryTime { get; set; }

    public string? BrojTelefona { get; set; }

    public List<string> Roles { get; } = [];
}

public class KorisnikUpdateDto
{
    public string Id { get; set; }
    public string Ime { get; set; } = string.Empty;

    public string? Email { get; set; }

    public string? Prezime { get; set; }

    public string? PasswordResetToken { get; set; }

    public string? EmailConfirmationToken { get; set; }

    public string RefreshToken { get; set; } = string.Empty;

    public DateTime RefreshTokenExpiryTime { get; set; }

    public string? BrojTelefona { get; set; }

    public List<string> Roles { get; } = [];
}
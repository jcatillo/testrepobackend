namespace Models
{
public class JwtSettings
{
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string Key { get; set; }
    public int TokenValidityMins { get; set; }
    public int RefreshTokenValidityMins { get; set; }
}}
namespace Models
{
    
/*
    Class to store the information for the JWT necessities (shown in appsettings.json)
 */   
public class JwtSettings
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Key { get; set; }
        public int TokenValidityMins { get; set; }
        public int RefreshTokenValidityMins { get; set; }
    }
}
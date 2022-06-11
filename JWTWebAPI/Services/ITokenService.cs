namespace JWTWebAPI.Services
{
    public interface ITokenService
    {
        string CreateToken(string token);
    }
}

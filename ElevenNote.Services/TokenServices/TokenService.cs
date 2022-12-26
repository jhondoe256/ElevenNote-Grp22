
using Microsoft.Extensions.Configuration;

public class TokenService : ITokenService
{
    private readonly ApplicationDbContext _context;
    private readonly IConfiguration _configuration;

    public TokenService(ApplicationDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }
}

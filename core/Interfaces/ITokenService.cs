using core.Entities.Identity;

namespace core.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
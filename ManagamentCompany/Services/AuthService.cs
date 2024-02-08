using Net14Web.DbStuff.ManagementCompany.Models;
using Net14Web.DbStuff.Repositories;

namespace Net14Web.Services
{
    public class AuthService
    {
        private UserRepository _userRepository;
        private IHttpContextAccessor _httpContextAccessor;

        public AuthService(IHttpContextAccessor httpContextAccessor,
            UserRepository mcUserRepository)
        {
            _httpContextAccessor = httpContextAccessor;// HttpContext == null
            _userRepository = mcUserRepository;
        }

        public User GetCurrentMcUser()
        {
            var idStr = _httpContextAccessor.HttpContext.User.Claims.First(x => x.Type == "id").Value;
            var id = int.Parse(idStr);
            return _userRepository.GetById(id);
        }
    }
}

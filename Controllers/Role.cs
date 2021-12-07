using Microsoft.AspNetCore.Mvc;
using Moteur.Role;
using Moteur;
namespace LoupGraou.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class Role
    {
        private readonly IGameHandler _gameHandler;
        [HttpGet]
        public List<IRole> GetRoles()
        {
            return new List<IRole>();
        }
    }
}

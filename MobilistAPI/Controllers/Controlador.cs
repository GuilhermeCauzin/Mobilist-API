using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobilistAPI.Models;

namespace MobilistAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class Controlador : ControllerBase
    {
        public readonly ProjetoMobilistContext _context;

        public Controlador(ProjetoMobilistContext context)
        {
            _context = context;
        }

        //Adicionar autorização necessária para endpoint: [Authorize(Roles="Administrator")]
        

    }
}

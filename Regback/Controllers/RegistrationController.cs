using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Regback.Models;

namespace Regback.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly RegistrationDbContext _registrationDbContext;
        public RegistrationController(RegistrationDbContext registrationDbContext)
        {
            _registrationDbContext = registrationDbContext;
        }
        [HttpPost]
        [Route("AddUser")]
        public async Task<Registration> AddUser(Registration objRegistration)
        {
            _registrationDbContext.registrations.Add(objRegistration);
            await _registrationDbContext.SaveChangesAsync();
            return objRegistration;
        }
    }
}

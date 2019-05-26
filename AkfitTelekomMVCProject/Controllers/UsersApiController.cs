using AktifTelekom.DAL;
using AktifTelekomMVCProject.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AkfitTelekomMVCProject.Controllers
{
    public class UsersApiController : ApiController
    {
        private readonly UsersService _usersService;
        public UsersApiController(UsersService usersService)

        {
            _usersService = usersService;
        }

        [Route("api/users")]
        [HttpGet]
        // GET: api/UsersApi
        public async Task<IEnumerable<Users>> Get()
        {
            return await _usersService.GetAll();
        }

        // GET: api/UsersApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UsersApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UsersApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UsersApi/5
        public void Delete(int id)
        {
        }
    }
}

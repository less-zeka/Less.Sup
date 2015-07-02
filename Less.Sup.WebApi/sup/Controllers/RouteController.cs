using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Less.Sup.WebApi.Models;

namespace Less.Sup.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] 
    public class RouteController : ApiController
    {
        private readonly ISupContext _database;

        public RouteController(ISupContext dbContext)
        {
            _database = dbContext;
        }

        // GET api/Route
        public IEnumerable<Route> GetRoutes()
        {
            return _database.Routes.AsEnumerable();
        }

        // GET api/Route/5
        public IHttpActionResult Get(int id)
        {
            var route = _database.Routes.FirstOrDefault(r => r.Id == id);
            if (route == null)
            {
                return NotFound();
            }

            return Ok(route);
        }

           // PUT api/route/5

        public IHttpActionResult Put(int id, Route route)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _database.Routes.AddOrUpdate(route);
            return Ok(route);
        }
    }
}
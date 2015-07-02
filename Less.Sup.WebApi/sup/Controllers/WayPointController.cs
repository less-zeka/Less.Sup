using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Less.Sup.WebApi.Models;

namespace Less.Sup.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class WayPointController : ApiController
    {
        private readonly ISupContext _database = new SupContext();

        public WayPointController(ISupContext dbContext)
        {
            _database = dbContext;
        }

        // GET api/Route/5
        public IHttpActionResult Get(int id)
        {
            var wayPoint = _database.WayPoints.FirstOrDefault(wp => wp.Id == id);
            if (wayPoint == null)
            {
                return NotFound();
            }
            return Ok(wayPoint);
        }
    }
}
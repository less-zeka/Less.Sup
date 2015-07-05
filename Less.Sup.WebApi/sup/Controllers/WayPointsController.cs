using System.Data.Entity.Spatial;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using Less.Sup.WebApi.Models;
using Less.Sup.WebApi.Utils;

namespace Less.Sup.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class WayPointsController : ApiController
    {
        private readonly ISupContext _database = new SupContext();

        public WayPointsController(ISupContext dbContext)
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

        // POST: api/Routes
        [ResponseType(typeof(WayPoint))]
        public async Task<IHttpActionResult> PostWayPoint(WayPoint wayPoint)
        {
            if (wayPoint.DbGeography == null)
            {
                wayPoint.DbGeography = GeoUtils.CreatePoint(wayPoint.Longitude, wayPoint.Latitude);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _database.WayPoints.Add(wayPoint);
            await _database.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = wayPoint.Id }, wayPoint);
        }
    }
}
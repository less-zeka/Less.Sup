using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Sup.Models;

namespace Sup.Controllers
{
           
    [EnableCors(origins: "*", headers: "*", methods: "*")] 
    public class WayPointController : ApiController
    {
        private readonly SupContext _database = new SupContext();

        //// GET api/WayPoints/routeId
        //public IEnumerable<WayPoint> GetWayPoints(int routeId)
        //{
        //    return _database.WayPoints.Where(wp => wp.RouteId == routeId).AsEnumerable();
        //}

        // GET api/Route/5
        public WayPoint Get(int id)
        {
            var wayPoint = _database.WayPoints.FirstOrDefault(wp => wp.Id == id);
            if (wayPoint == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return wayPoint;
        }



       

        // POST api/Route
        //public HttpResponseMessage PostRoute(Route route)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _database.Routes.Add(route);
        //        _database.SaveChanges();

        //        HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, route);
        //        response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = route.Id }));
        //        return response;
        //    }
        //    else
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }
        //}

        // DELETE api/Route/5
        //public HttpResponseMessage DeleteRoute(int id)
        //{
        //    Route route = _database.Routes.Find(id);
        //    if (route == null)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotFound);
        //    }

        //    _database.Routes.Remove(route);

        //    try
        //    {
        //        _database.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
        //    }

        //    return Request.CreateResponse(HttpStatusCode.OK, route);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    _database.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}
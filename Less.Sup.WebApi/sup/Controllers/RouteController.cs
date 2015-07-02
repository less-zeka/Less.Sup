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
    public class RouteController : ApiController
    {
        private readonly SupContext _database = new SupContext();

        public RouteController(IDbContext dbContext)
        {
            this._database = dbContext;
        }

        // GET api/Route
        public IEnumerable<Route> GetRoutes()
        {
            return _database.Routes.AsEnumerable();
        }

        // GET api/Route/5
        public Route Get(int id)
        {
            var route = _database.Routes.FirstOrDefault(r => r.Id == id);
            if (route == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return route;
        }

        //public Route GetRoute(double longitude, double latitude)
        //{
        //    var myLocation = DbGeography.FromText(string.Format("POINT({0} {1})", longitude, latitude));

        //    var closestLocation = (from u in _database.Locations
        //                      orderby u.Point.Distance(myLocation)
        //                      select u).FirstOrDefault(); 

        //    return GetRoute(closestLocation.RouteId);
        //}

        // PUT api/Route/5
        //public HttpResponseMessage PutRoute(int id, Route route)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }

        //    if (id != route.Id)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.BadRequest);
        //    }

        //    _database.Entry(route).State = EntityState.Modified;

        //    try
        //    {
        //        _database.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
        //    }

        //    return Request.CreateResponse(HttpStatusCode.OK);
        //}

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
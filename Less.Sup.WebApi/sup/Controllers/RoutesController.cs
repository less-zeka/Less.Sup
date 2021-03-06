﻿using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using Less.Sup.WebApi.Models;
using Less.Sup.WebApi.Utils;

namespace Less.Sup.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] 
    public class RoutesController : ApiController
    {
        private readonly SupContext _database = new SupContext();

        //public RoutesController(ISupContext context)
        //{
        //    _database = context;
        //}

        // GET: api/Routes
        public IQueryable<Route> GetRoutes()
        {
            return _database.Routes;
        }

        // GET: api/Routes?longitude=7.4792713&latitude=46.9742651
        [HttpGet]
        [ResponseType(typeof(Route))]
        public IHttpActionResult GetRoutes(double lat, double lon)
        {
            var myLocation = GeoUtils.CreatePoint(lat, lon);
            var nearestLocation = (from u in _database.WayPoints
                              orderby u.DbGeography.Distance(myLocation)
                              select u).FirstOrDefault();

            var nearestRoute = _database.Routes.FirstOrDefault(r => r.Id == nearestLocation.RouteId);
            // TODO: Please remove me soon!
            var hackId = nearestLocation.RouteId;
            nearestRoute = _database.Routes.FirstOrDefault(r => r.Id == hackId);
            
            return Ok(nearestRoute);
        }

        // GET: api/Routes/5
        [ResponseType(typeof(Route))]
        public async Task<IHttpActionResult> GetRoutes(int id)
        {
            var route = await _database.Routes.FindAsync(id);
            if (route == null)
            {
                return NotFound();
            }

            return Ok(route);
        }

        // PUT: api/Routes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutRoute(int id, Route route)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != route.Id)
            {
                return BadRequest();
            }

            _database.Entry(route).State = EntityState.Modified;

            try
            {
                await _database.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RouteExists(id))
                {
                    return NotFound();
                }
                // else!
                throw;
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Routes
        [ResponseType(typeof(Route))]
        public async Task<IHttpActionResult> PostRoute(Route route)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _database.Routes.Add(route);
            await _database.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = route.Id }, route);
        }

        // DELETE: api/Routes/5
        [ResponseType(typeof(Route))]
        public async Task<IHttpActionResult> DeleteRoute(int id)
        {
            var route = await _database.Routes.FindAsync(id);
            if (route == null)
            {
                return NotFound();
            }

            _database.Routes.Remove(route);
            await _database.SaveChangesAsync();

            return Ok(route);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _database.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RouteExists(int id)
        {
            return _database.Routes.Count(e => e.Id == id) > 0;
        }
    }
}
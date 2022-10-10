using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SQL.Entities;

namespace SQL.Controllers
{
    public class climbersController : ApiController
    {
        private Entities db = new Entities();

        // GET: api/climbers
        public IQueryable<climber> Getclimber()
        {
            return db.climber;
        }

        // GET: api/climbers/5
        [ResponseType(typeof(climber))]
        public IHttpActionResult Getclimber(int id)
        {
            climber climber = db.climber.Find(id);
            if (climber == null)
            {
                return NotFound();
            }

            return Ok(climber);
        }

        // PUT: api/climbers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putclimber(int id, climber climber)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != climber.cod_climber)
            {
                return BadRequest();
            }

            db.Entry(climber).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!climberExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/climbers
        [ResponseType(typeof(climber))]
        public IHttpActionResult Postclimber(climber climber)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.climber.Add(climber);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = climber.cod_climber }, climber);
        }

        // DELETE: api/climbers/5
        [ResponseType(typeof(climber))]
        public IHttpActionResult Deleteclimber(int id)
        {
            climber climber = db.climber.Find(id);
            if (climber == null)
            {
                return NotFound();
            }

            db.climber.Remove(climber);
            db.SaveChanges();

            return Ok(climber);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool climberExists(int id)
        {
            return db.climber.Count(e => e.cod_climber == id) > 0;
        }
    }
}
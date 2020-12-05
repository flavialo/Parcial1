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
using ParcialFlaviaLarrain.Models;
using PracticaParcial.Models;

namespace ParcialFlaviaLarrain.Controllers
{
    public class NumeroesController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Numeroes
        public IQueryable<Numero> GetNumeroes()
        {
            return db.Numeroes;
        }

        // GET: api/Numeroes/5
        [ResponseType(typeof(Numero))]
        public IHttpActionResult GetNumero(int id)
        {
            Numero numero = db.Numeroes.Find(id);
            if (numero == null)
            {
                return NotFound();
            }

            return Ok(numero);
        }

        // PUT: api/Numeroes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNumero(int id, Numero numero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != numero.numero)
            {
                return BadRequest();
            }

            db.Entry(numero).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NumeroExists(id))
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

        // POST: api/Numeroes
        [ResponseType(typeof(Numero))]
        public IHttpActionResult PostNumero(Numero numero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Numeroes.Add(numero);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = numero.numero }, numero);
        }

        // DELETE: api/Numeroes/5
        [ResponseType(typeof(Numero))]
        public IHttpActionResult DeleteNumero(int id)
        {
            Numero numero = db.Numeroes.Find(id);
            if (numero == null)
            {
                return NotFound();
            }

            db.Numeroes.Remove(numero);
            db.SaveChanges();

            return Ok(numero);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NumeroExists(int id)
        {
            return db.Numeroes.Count(e => e.numero == id) > 0;
        }
    }
}
using Covid19Tracker.Data;
using Covid19Tracker.Models;
using Covid19Tracker.Services;
using Covid19Tracker.WebAPI.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Covid19Tracker.WebAPI.Controllers
{
    public class CountyController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private CountyService CreateService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var countyService = new CountyService(userId);
            return countyService;
        }

        // Post
        public IHttpActionResult Create(PostCounty post)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState); // 400
            var service = CreateService();
            if (!service.CreatePost(post))
                return InternalServerError();
            return Ok(); // 
        }

       

        // Read

        [HttpGet]
        public async Task<IHttpActionResult> GetAllCounty()
        {
            List<County> posts = await _context.Counties.ToListAsync();
           
            return Ok(posts);

        }

        // Update

        [HttpPut]
        public async Task<IHttpActionResult> UpdateCounty([FromUri] int id, [FromBody] County model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400
            }

            County county = await _context.Counties.FindAsync(id);
            if (county == null)
            {
                return NotFound(); // 404
            }

            county.CountyName = model.CountyName;
            county.Population = model.Population;

            if (await _context.SaveChangesAsync() == 1) // Save changes
            {
                return Ok();
            }

            return InternalServerError(); // 500
        }




        // Delete

        [HttpDelete]

        public async Task<IHttpActionResult> DeleteCounty(int id)
        {
            County county = await _context.Counties.FindAsync(id);
            if (county == null)
            {
                return NotFound(); // 404
            }

            _context.Counties.Remove(county);

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok();
            }

            return InternalServerError(); // 500
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetCountyById(int id)
        {
            County county = await _context.Counties.FindAsync(id);

            if (county != null)
            {
                return Ok(county); // Status code http: 200
            }

            return NotFound(); // 404
        }

    }
}

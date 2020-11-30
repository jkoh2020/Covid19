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

       

        // Read - get all counties

        //[HttpGet]
        //public async Task<IHttpActionResult> GetAllCounty()
        //{
        //    List<County> posts = await _context.Counties.ToListAsync();
           
        //    return Ok(posts);

        //}

        // Get all counties
        public IHttpActionResult GetAllCounty()
        {
            CountyService countyService = CreateService();
            var county = countyService.GetCounty();
            return Ok(county);
        }
       
        // Update
        public IHttpActionResult Put(CountyEdit edit)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateService();
            if (!service.UpdateCounty(edit))
                return InternalServerError();
            return Ok();
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

        // Get county by id

        //[HttpGet]
        //public async Task<IHttpActionResult> GetCountyById(int id)
        //{
        //    County county = await _context.Counties.FindAsync(id);

        //    if (county != null)
        //    {
        //        return Ok(county); // Status code http: 200
        //    }

        //    return NotFound(); // 404
        //}

        public IHttpActionResult Get(int id)
        {
            CountyService countyService = CreateService();
            var county = countyService.GetCountyById(id);
            return Ok(county);
        }

    }
}

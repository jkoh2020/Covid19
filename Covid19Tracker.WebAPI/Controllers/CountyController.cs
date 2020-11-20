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

        /*public IHttpActionResult CreateData(PostCountyData post)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState); // 400
            var service = CreateService();
            if (!service.CreatePostData(post))
                return InternalServerError();
            return Ok(); // 
        }*/

        // Read

        [HttpGet]
        public async Task<IHttpActionResult> GetAllCounty()
        {
            List<County> posts = await _context.Counties.ToListAsync();
           
            return Ok(posts);

        }

        /*
        public async Task<IHttpActionResult> GetAllCountyData()
        {
           
            List<CountyData> post = await _context.CountiesData.ToListAsync();
            return Ok(post);

        }*/
    }
}

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
    public class CountyDataController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private CountyDataService CreateService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var countyDataService = new CountyDataService(userId);
            return countyDataService;
        }

       // Post county data
        public IHttpActionResult CreateData(PostCountyData post)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState); // 400

            var service = CreateService();

            if (!service.CreatePostData(post))
            
                return InternalServerError();
                      
            return Ok(); // 
        }
           
        
        // Get All
        [HttpGet]
        public async Task<IHttpActionResult> GetAllCountyData()
        {

            List<CountyData> post = await _context.CountiesData.ToListAsync();
            return Ok(post);

        }

        
        // Get by id

        [HttpGet]

        public async Task<IHttpActionResult> GetById(int id)
        {
            CountyData data = await _context.CountiesData.FindAsync(id);

            if (data != null)
            {
                return Ok(data); // Status code http: 200
            }

            return NotFound(); // 404
        }

    }
}

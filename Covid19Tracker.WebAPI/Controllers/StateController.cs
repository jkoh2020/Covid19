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
    public class StateController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private StateService CreateService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var stateService = new StateService(userId);
            return stateService;
        }

        // Post
        public IHttpActionResult Create(PostState post)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState); // 400
            var service = CreateService();
            if (!service.CreatePost(post))
                return InternalServerError();
            return Ok(); // 
        }

        // Read - get all state

        [HttpGet]
        public async Task<IHttpActionResult> GetAllCounty()
        {
            List<State> posts = await _context.States.ToListAsync();

            return Ok(posts);

        }
    }
}

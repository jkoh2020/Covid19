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

        // Post state
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

        //Update 

       [HttpPut]
        public async Task<IHttpActionResult> UpdateCounty([FromUri] int id, [FromBody] State model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400
            }

            State state = await _context.States.FindAsync(id);
            if (state == null)
            {
                return NotFound(); // 404
            }

            state.StateName = model.StateName;
            state.Population = model.Population;

            if (await _context.SaveChangesAsync() == 1) // Save changes
            {
                return Ok();
            }

            return InternalServerError(); // 500
        }

        // Delete 

        [HttpDelete]

        public async Task<IHttpActionResult> DeleteState(int id)
        {
            State state = await _context.States.FindAsync(id);
            if (state == null)
            {
                return NotFound(); // 404
            }

            _context.States.Remove(state);

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok();
            }

            return InternalServerError(); // 500
        }

        // Read county by id

        [HttpGet]
        public async Task<IHttpActionResult> GetStateById(int id)
        {
            State state = await _context.States.FindAsync(id);

            if (state != null)
            {
                return Ok(state); // Status code http: 200
            }

            return NotFound(); // 404
        }
    }
}

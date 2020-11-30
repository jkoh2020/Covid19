using Covid19Tracker.Data;
using Covid19Tracker.Models;
using Covid19Tracker.Services;
using Covid19Tracker.WebAPI.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Covid19Tracker.WebAPI.Controllers
{
    public class StateDataController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private StateDataService CreateService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var stateDataService = new StateDataService(userId);
            return stateDataService;
        }

        // Post state data
        public IHttpActionResult Create(PostStateData post)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState); // 400
            var service = CreateService();
            if (!service.CreatePostData(post))
                return InternalServerError();
            return Ok(); // 
        }

        // Get all state data
        public IHttpActionResult GetAllStateData()
        {
            StateDataService stateDataService = CreateService();
            var state = stateDataService.GetStateData();
            return Ok(state);
        }

        // Get state data by id
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            StateData data = await _context.StatesData.FindAsync(id);
            if (data != null)
            {
                return Ok(data);
            }

            return NotFound(); // 404
        }

    }
}

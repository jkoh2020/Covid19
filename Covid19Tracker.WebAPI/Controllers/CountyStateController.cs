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
    public class CountyStateController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private CountyService CreateService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var countyService = new CountyService(userId);
            return countyService;
        }

        // Get state and county data by id
        [HttpGet]
        public async Task<IHttpActionResult> Comparison([FromUri] int countyId, [FromUri] int stateId, [FromBody] GetCounties model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400
            }

            County county = await _context.Counties.FindAsync(countyId);
            State state = await _context.States.FindAsync(stateId);
            CountyState compare = new CountyState            
            {
                
                CountyId = county.CountyId,
                CountyName = county.CountyName,
                CountyPopulation = county.Population,
                CountyTotalTests = county.CountyData.Sum(x => x.TodayTests),
                CountyTotalConfirmedCases = county.CountyData.Sum(x => x.TodayConfirmedCases),
                CountyTotalDeaths = county.CountyData.Sum(x => x.TodayDeaths),
                StateId = state.StateId,
                StateName = state.StateName,
                StatePopulation = state.Population,
                StateTotalTests = state.StateData.Sum(x => x.TodayTests),
                StateTotalConfirmedCases = state.StateData.Sum(x => x.TodayConfirmedCases),
                StateTotalDeaths = state.StateData.Sum(x => x.TodayDeaths),

            };

            if (county == null || state == null)
            {
                return NotFound();
            }

            return Ok(compare);

        }
    }
}

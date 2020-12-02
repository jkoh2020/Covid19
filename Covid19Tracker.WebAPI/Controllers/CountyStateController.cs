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


// This coding no longer using. We kept it for a future reference.
namespace Covid19Tracker.WebAPI.Controllers
{
    public class CountyStateController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        
        // Get state and county data by id
        [HttpGet]
        
        public async Task<IHttpActionResult> Comparison([FromUri] int countyId, [FromUri] int stateId) // [FromBody] GetCounties model
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400
            }

            County county = await _context.Counties.FindAsync(countyId);
            State state = await _context.States.FindAsync(stateId);

            if (county == null || state == null)
            {
                return NotFound();
            }

            CountyState compare = new CountyState
            {

                CountyId = county.CountyId,
                CountyName = county.CountyName,
                CountyPopulation = county.Population,
                CountyTotalTests = county.CountyData.Sum(x => x.TodayTests),
                CountyTotalConfirmedCases = Convert.ToDouble(county.CountyData.Sum(x => x.TodayConfirmedCases)),
                CountyTotalDeaths = Convert.ToDouble(county.CountyData.Sum(x => x.TodayDeaths)),
                CoutyFatalityRate = Math.Round((Convert.ToDouble(county.CountyData.Sum(x => x.TodayDeaths)) / county.CountyData.Sum(x => x.TodayConfirmedCases)) * 100, 5),
                CountyPositivePercentage = Math.Round((Convert.ToDouble(county.CountyData.Sum(x => x.TodayConfirmedCases)) / county.Population) * 100, 5),

                StateId = state.StateId,
                StateName = state.StateName,
                StatePopulation = state.Population,
                StateTotalTests = state.StateData.Sum(x => x.TodayTests),
                StateTotalConfirmedCases = Convert.ToDouble( state.StateData.Sum(x => x.TodayConfirmedCases)),
                StateTotalDeaths = Convert.ToDouble(state.StateData.Sum(x => x.TodayDeaths)),
                StateFatalityRate = Math.Round((Convert.ToDouble(state.StateData.Sum(x => x.TodayDeaths)) / state.StateData.Sum(x => x.TodayConfirmedCases)) * 100, 5),
                StatePositivePercentage = Math.Round(Convert.ToDouble(state.StateData.Sum(x => x.TodayConfirmedCases)) / state.Population, 5)

            };
                  
            return Ok(compare);

        }

    }
}


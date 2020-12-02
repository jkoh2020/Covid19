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
    public class StateToStateController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        
        // Get state to state data by id
        [HttpGet]
       
        public async Task<IHttpActionResult> Comparison([FromUri] int stateId, [FromUri] int secondStateId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400
            }

            State state = await _context.States.FindAsync(stateId);
            State secondState = await _context.States.FindAsync(secondStateId);
            
            if (state == null || secondState == null)
            {
                return NotFound();
            }

            StateToState compare = new StateToState

            {

                StateId = state.StateId,
                StateName = state.StateName,
                StatePopulation = state.Population,
                StateTotalTests = state.StateData.Sum(x => x.TodayTests),
                StateTotalConfirmedCases = Convert.ToDouble(state.StateData.Sum(x => x.TodayConfirmedCases)),
                StateTotalDeaths = Convert.ToDouble(state.StateData.Sum(x => x.TodayDeaths)),
                StateFatalityRate = Convert.ToDouble(state.StateData.Sum(x => x.TodayDeaths)) / state.StateData.Sum(x => x.TodayConfirmedCases),
                StatePositivePercentage = Convert.ToDouble(state.StateData.Sum(x => x.TodayConfirmedCases)) / state.Population,

                SecondStateId = secondState.StateId,
                SecondStateName = secondState.StateName,
                SecondStatePopulation = secondState.Population,
                SecondStateTotalTests = secondState.StateData.Sum(x => x.TodayTests),
                SecondStateTotalConfirmedCases = Convert.ToDouble(secondState.StateData.Sum(x => x.TodayConfirmedCases)),
                SecondStateTotalDeaths = Convert.ToDouble(secondState.StateData.Sum(x => x.TodayDeaths)),
                SecondStateFatalityRate = Math.Round(Convert.ToDouble(secondState.StateData.Sum(x => x.TodayDeaths)) / secondState.StateData.Sum(x => x.TodayConfirmedCases), 5),
                SecondStatePositivePercentage = Math.Round(Convert.ToDouble(secondState.StateData.Sum(x => x.TodayConfirmedCases)) / secondState.Population)

            };

            return Ok(compare);
        }


    }
}

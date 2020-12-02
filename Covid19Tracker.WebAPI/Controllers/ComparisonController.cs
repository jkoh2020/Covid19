using Covid19Tracker.Data;
using Covid19Tracker.Models;
using Covid19Tracker.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Covid19Tracker.WebAPI.Controllers
{
    public class ComparisonController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // Get county and state data by id
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
                CoutyFatalityRate = Math.Round((Convert.ToDouble(county.CountyData.Sum(x => x.TodayDeaths)) / county.CountyData.Sum(x => x.TodayConfirmedCases)) * 100, 2),
                CountyPositivePercentage = Math.Round((Convert.ToDouble(county.CountyData.Sum(x => x.TodayConfirmedCases)) / county.Population) * 100, 2),

                StateId = state.StateId,
                StateName = state.StateName,
                StatePopulation = state.Population,
                StateTotalTests = state.StateData.Sum(x => x.TodayTests),
                StateTotalConfirmedCases = Convert.ToDouble(state.StateData.Sum(x => x.TodayConfirmedCases)),
                StateTotalDeaths = Convert.ToDouble(state.StateData.Sum(x => x.TodayDeaths)),
                StateFatalityRate = Math.Round((Convert.ToDouble(state.StateData.Sum(x => x.TodayDeaths)) / state.StateData.Sum(x => x.TodayConfirmedCases)) * 100, 2),
                StatePositivePercentage = Math.Round((Convert.ToDouble(state.StateData.Sum(x => x.TodayConfirmedCases)) / state.Population) * 100, 2)

            };

            return Ok(compare);

        }

        [HttpGet]
        public async Task<IHttpActionResult> CountyComparison([FromUri] int countyId, [FromUri] int secondCountyId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400
            }

            County county = await _context.Counties.FindAsync(countyId);
            County secondCounty = await _context.Counties.FindAsync(secondCountyId);

            if (county == null || secondCounty == null)
            {
                return NotFound();
            }

            CountyToCounty compare = new CountyToCounty
            {

                CountyId = county.CountyId,
                CountyName = county.CountyName,
                CountyPopulation = county.Population,
                CountyTotalTests = county.CountyData.Sum(x => x.TodayTests),
                CountyTotalConfirmedCases = Convert.ToDouble(county.CountyData.Sum(x => x.TodayConfirmedCases)),
                CountyTotalDeaths = Convert.ToDouble(county.CountyData.Sum(x => x.TodayDeaths)),
                CoutyFatalityRate = Math.Round((Convert.ToDouble(county.CountyData.Sum(x => x.TodayDeaths)) / county.CountyData.Sum(x => x.TodayConfirmedCases)) * 100, 2),
                CountyPositivePercentage = Math.Round((Convert.ToDouble(county.CountyData.Sum(x => x.TodayConfirmedCases)) / county.Population) * 100, 2),

                SecondCountyId = secondCounty.CountyId,
                SecondCountyName = secondCounty.CountyName,
                SecondCountyPopulation = secondCounty.Population,
                SecondCountyTotalTests = secondCounty.CountyData.Sum(x => x.TodayTests),
                SecondCountyTotalConfirmedCases = Convert.ToDouble(secondCounty.CountyData.Sum(x => x.TodayConfirmedCases)),
                SecondCountyTotalDeaths = Convert.ToDouble(secondCounty.CountyData.Sum(x => x.TodayDeaths)),
                SecondCoutyFatalityRate = Math.Round((Convert.ToDouble(secondCounty.CountyData.Sum(x => x.TodayDeaths)) / secondCounty.CountyData.Sum(x => x.TodayConfirmedCases)) * 100, 2),
                SecondCountyPositivePercentage = Math.Round((Convert.ToDouble(secondCounty.CountyData.Sum(x => x.TodayConfirmedCases)) / secondCounty.Population) * 100, 2),

            };

            return Ok(compare);

        }

        [HttpGet]

        public async Task<IHttpActionResult> StateComparison([FromUri] int stateId, [FromUri] int secondStateId)
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
                StateFatalityRate = Math.Round((Convert.ToDouble(state.StateData.Sum(x => x.TodayDeaths)) / state.StateData.Sum(x => x.TodayConfirmedCases)) * 100, 2),
                StatePositivePercentage = Math.Round((Convert.ToDouble(state.StateData.Sum(x => x.TodayConfirmedCases)) / state.Population) * 100, 2),

                SecondStateId = secondState.StateId,
                SecondStateName = secondState.StateName,
                SecondStatePopulation = secondState.Population,
                SecondStateTotalTests = secondState.StateData.Sum(x => x.TodayTests),
                SecondStateTotalConfirmedCases = Convert.ToDouble(secondState.StateData.Sum(x => x.TodayConfirmedCases)),
                SecondStateTotalDeaths = Convert.ToDouble(secondState.StateData.Sum(x => x.TodayDeaths)),
                SecondStateFatalityRate = Math.Round((Convert.ToDouble(secondState.StateData.Sum(x => x.TodayDeaths)) / secondState.StateData.Sum(x => x.TodayConfirmedCases)) * 100, 2),
                SecondStatePositivePercentage = Math.Round((Convert.ToDouble(secondState.StateData.Sum(x => x.TodayConfirmedCases)) / secondState.Population) * 100, 2)

            };

            return Ok(compare);
        }
    }
}

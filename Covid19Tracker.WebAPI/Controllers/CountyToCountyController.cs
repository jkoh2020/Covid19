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


// This coding no longer using. We kept it for a future reference.
namespace Covid19Tracker.WebAPI.Controllers
{
    public class CountyToCountyController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // Get county to  county data by id
        [HttpGet]
        public async Task<IHttpActionResult> Comparison([FromUri] int countyId, [FromUri] int secondCountyId) 
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
                CoutyFatalityRate = Math.Round(Convert.ToDouble(county.CountyData.Sum(x => x.TodayDeaths)) / county.CountyData.Sum(x => x.TodayConfirmedCases), 5),
                CountyPositivePercentage = Math.Round(Convert.ToDouble(county.CountyData.Sum(x => x.TodayConfirmedCases)) / county.Population, 5),

                SecondCountyId = secondCounty.CountyId,
                SecondCountyName = secondCounty.CountyName,
                SecondCountyPopulation = secondCounty.Population,
                SecondCountyTotalTests = secondCounty.CountyData.Sum(x => x.TodayTests),
                SecondCountyTotalConfirmedCases = Convert.ToDouble(secondCounty.CountyData.Sum(x => x.TodayConfirmedCases)),
                SecondCountyTotalDeaths = Convert.ToDouble(secondCounty.CountyData.Sum(x => x.TodayDeaths)),
                SecondCoutyFatalityRate = Math.Round(Convert.ToDouble(secondCounty.CountyData.Sum(x => x.TodayDeaths)) / secondCounty.CountyData.Sum(x => x.TodayConfirmedCases), 5),
                SecondCountyPositivePercentage = Math.Round(Convert.ToDouble(secondCounty.CountyData.Sum(x => x.TodayConfirmedCases)) / secondCounty.Population, 5),



            };

            return Ok(compare);

        }
    }
}

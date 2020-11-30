using Covid19Tracker.Data;
using Covid19Tracker.Models;
using Covid19Tracker.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Services
{
   public class CountyService
    {
        private readonly Guid _userId;
        public CountyService(Guid userId)
        {
            _userId = userId;
        }

        // Posting county
        public bool CreatePost(PostCounty model)
        {
            var entity = new County()
            {
                UserId = _userId,
                CountyName = model.CountyName,
                Population = model.Population,
               
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Counties.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        

        // Get County

        public IEnumerable<GetCounties> GetCounty()
        {

            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Counties
                        .Select(e => new GetCounties
                        {
                            CountyData = e.CountyData.Select(X=> new GetCountiesData { DataId = X.DataId, UserId = X.UserId, Date = X.Date, CountyId = X.CountyId, TodayTests = X.TodayTests, TodayConfirmedCases = X.TodayConfirmedCases, TodayDeaths = X.TodayDeaths }).ToList(),
                            CountyId = e.CountyId,
                            CountyName = e.CountyName,
                            Population = e.Population,
                            TotalTests = e.CountyData.Sum(x => x.TodayTests),
                            TotalConfirmedCases = e.CountyData.Sum(x => x.TodayConfirmedCases),
                            TotalDeaths = e.CountyData.Sum(x => x.TodayDeaths)
                        });
                return query.ToArray();
            }
        }

        // Update county
        public bool UpdateCounty(CountyEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Counties
                        .Single(e => e.CountyId == model.CountyId && e.UserId == _userId);

                entity.CountyName = model.CountyName;
                entity.Population = model.Population;

                return ctx.SaveChanges() == 1;

            }
        }

        
    }
}




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

        // Post county
        public bool CreatePost(PostCounty model)
        {
            var entity = new County()
            {
                UserId = _userId,
                CountyName = model.CountyName,
                Population = model.Population,
                CreatedDate = DateTimeOffset.Now

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
                        //.Where(e => e.UserId == _userId)
                        .Select(e => new GetCounties
                        {
                            CountyData = e.CountyData.Select(x => new GetCountiesData { DataId = x.DataId, /*UserId = x.UserId,*/ Date = x.Date, CountyId = x.CountyId, CountyName = x.CountyName, TodayTests = x.TodayTests, TodayConfirmedCases = x.TodayConfirmedCases, TodayDeaths = x.TodayDeaths, CreatedDate = x.CreatedDate }).ToList(),
                            CountyId = e.CountyId,
                            CountyName = e.CountyName,
                            Population = e.Population,
                            TotalTests = e.CountyData.Sum(x => x.TodayTests),
                            TotalConfirmedCases = e.CountyData.Sum(x => x.TodayConfirmedCases),
                            TotalDeaths = e.CountyData.Sum(x => x.TodayDeaths),

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

                entity.Population = model.Population;
                entity.ModifiedDate = DateTimeOffset.Now;
                return ctx.SaveChanges() == 1;

            }
        }

        // Get county by id
        public GetCounties GetCountyById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Counties
                        .SingleOrDefault(e => e.CountyId == id && e.UserId == _userId);

                if (entity != null)
                {
                    return
                        new GetCounties
                        {
                            CountyData = entity.CountyData.Select(x => new GetCountiesData { DataId = x.DataId, /*UserId = x.UserId,*/ Date = x.Date, CountyId = x.CountyId, CountyName = x.CountyName, TodayTests = x.TodayTests, TodayConfirmedCases = x.TodayConfirmedCases, TodayDeaths = x.TodayDeaths, CreatedDate = x.CreatedDate }).ToList(),
                            CountyId = entity.CountyId,
                            CountyName = entity.CountyName,
                            Population = entity.Population,
                            TotalTests = entity.CountyData.Sum(x => x.TodayTests),
                            TotalConfirmedCases = entity.CountyData.Sum(x => x.TodayConfirmedCases),
                            TotalDeaths = entity.CountyData.Sum(x => x.TodayDeaths),


                        };
                }
                else { return null; }

            }
        }
    }
}




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
    public class CountyDataService
    {
        private readonly Guid _userId;
        public CountyDataService(Guid userId)
        {
            _userId = userId;
        }

        // Post county data

        public bool CreatePostData(PostCountyData model)
        {
            var entity = new CountyData()
            {
                UserId = _userId,
                Date = model.Date,
                TodayTests = model.TodayTests,
                TodayConfirmedCases = model.TodayConfirmedCases,
                TodayDeaths = model.TodayDeaths,
                CountyId = model.CountyId,
                CountyName = model.CountyName,
                CreatedDate = DateTimeOffset.Now

            };

            using (var ctx = new ApplicationDbContext())
            {
                
                ctx.CountiesData.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        // Get county data
        public IEnumerable<GetCountiesData> GetCountyData()
        {
            using (var ctx = new ApplicationDbContext())
            {
                //int totalDeaths = 0;

                //foreach (var dailyDeaths in ctx.CountiesData)
                //{
                //    totalDeaths = totalDeaths + dailyDeaths.TodayDeaths;
                //}

                var query =
                    ctx
                        .CountiesData
                        .Where(e => e.UserId == _userId)
                        .Select(e => new GetCountiesData
                        {

                            DataId = e.DataId,
                            Date = e.Date,
                            CountyId = e.CountyId,
                            CountyName = e.CountyName,
                            TodayTests = e.TodayTests,
                            TodayConfirmedCases = e.TodayConfirmedCases,
                            TodayDeaths = e.TodayDeaths,
                            CreatedDate = e.CreatedDate
                        });
                        
                return query.ToArray();
            }
        }

        // County data by id
        public GetCountiesData GetCountyDataById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .CountiesData
                        .SingleOrDefault(e => e.DataId == id && e.UserId == _userId);
                if(entity != null)
                { 
                return
                    new GetCountiesData
                    {
                        DataId = entity.DataId,
                        Date = entity.Date,
                        CountyId = entity.CountyId,
                        CountyName = entity.CountyName,
                        TodayTests = entity.TodayTests,
                        TodayConfirmedCases = entity.TodayConfirmedCases,
                        TodayDeaths = entity.TodayDeaths,
                        CreatedDate = entity.CreatedDate
                    };
                }

                return null;

            }
        }


    }
}


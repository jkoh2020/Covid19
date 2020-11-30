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
    public class StateDataService
    {
        private readonly Guid _userId;
        public StateDataService(Guid userId)
        {
            _userId = userId;
        }

        // Posting state data
        public bool CreatePostData(PostStateData model)
        {
            var entity = new StateData()
            {
                UserId = _userId,
                StateName = model.StateName,
                TodayTests = model.TodayTests,
                TodayConfirmedCases = model.TodayConfirmedCases,
                TodayDeaths = model.TodayDeaths,
                StateId = model.StateId,
                CreatedDate = DateTimeOffset.Now


            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.StatesData.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        // Get state data

       public IEnumerable<GetStatesData> GetStateData()
        {
            using (var ctx = new ApplicationDbContext())
            {
                

                var query =
                    ctx
                        .StatesData
                        .Where(e => e.UserId == _userId)
                        .Select(e => new GetStatesData
                        {

                            DataId = e.DataId,
                            StateId = e.StateId,
                            StateName = e.StateName,
                            TodayTests = e.TodayTests,
                            TodayConfirmedCases = e.TodayConfirmedCases,
                            TodayDeaths = e.TodayDeaths,
                            CreatedDate = e.CreatedDate 

                        });

                return query.ToArray();
            }
        }
    }

   
}



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
   public class StateService
    {
        private readonly Guid _userId;
        public StateService(Guid userId)
        {
            _userId = userId;
        }

        // Post state
        public bool CreatePost(PostState model)
        {
            var entity = new State()
            {
                UserId = _userId,
                StateName = model.StateName,
                Population = model.Population,
                CreatedDate = DateTimeOffset.Now

            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.States.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        // Get state

        public IEnumerable<GetStates> GetState()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .States
                        //.Where(e => e.UserId == _userId)
                        .Select(e => new GetStates
                        {
                            StateId = e.StateId,
                            StateName = e.StateName,
                            Population = e.Population,
                            TotalTests = e.StateData.Sum(x => x.TodayTests),
                            TotalConfirmedCases = e.StateData.Sum(x => x.TodayConfirmedCases),
                            TotalDeaths = e.StateData.Sum(x => x.TodayDeaths),
                           
                        });
                return query.ToArray();
            }
        }

        // Get state by id

        public GetStates GetStateById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .States
                        .SingleOrDefault(e => e.StateId == id && e.UserId == _userId);
                if (entity != null)
                {
                    return
                    new GetStates
                    {

                        StateId = entity.StateId,
                        StateName = entity.StateName,
                        Population = entity.Population,
                        TotalTests = entity.StateData.Sum(x => x.TodayTests),
                        TotalConfirmedCases = entity.StateData.Sum(x => x.TodayConfirmedCases),
                        TotalDeaths = entity.StateData.Sum(x => x.TodayDeaths),

                    };
                }

                return null;         
            }
        }

       
       
        // Update state

        public bool UpdateState(StateEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .States
                        .Single(e => e.StateId == model.StateId && e.UserId == _userId);

                entity.Population = model.Population;
                entity.ModifiedDate = DateTimeOffset.Now;
                
                return ctx.SaveChanges() == 1;

            }
        }

    }
}

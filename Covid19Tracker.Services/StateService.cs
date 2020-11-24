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

        // Posting state
        public bool CreatePost(PostState model)
        {
            var entity = new State()
            {
                UserId = _userId,
                StateName = model.StateName,
                Population = model.Population,

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
                        .Where(e => e.UserId == _userId)
                        .Select(e => new GetStates
                        {
                            
                            StateId = e.StateId,
                            StateName = e.StateName,
                            Population = e.Population


                        });
                return query.ToArray();
            }
        }

    }
}

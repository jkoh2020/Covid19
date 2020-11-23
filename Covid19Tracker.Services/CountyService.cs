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
                        .Where(e => e.UserId == _userId)
                        .Select(e => new GetCounties
                        {
                            CountyId = e.CountyId,
                            CountyName = e.CountyName,
                            Population = e.Population,
                            CountyData = e.CountyData
                            
                        });
                return query.ToArray();
            }
        }

        
    }
}




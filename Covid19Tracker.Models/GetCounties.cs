using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Models
{
    public class GetCounties
    {
        public int CountyId { get; set; }
        public Guid UserId { get; set; }
        public string CountyName { get; set; }
        public int Population { get; set; }
    }
}

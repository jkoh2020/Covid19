using Covid19Tracker.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Models
{
   public class GetStates
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public int Population { get; set; }
        //public virtual List<StateData> StateData { get; set; }
        public int? TotalTests { get; set; }
        public int? TotalConfirmedCases { get; set; }
        public int? TotalDeaths { get; set; }

        //[Display(Name = "Created")]
        //public DateTimeOffset CreatedDate { get; set; }


    }
}

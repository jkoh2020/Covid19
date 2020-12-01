using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Models
{
    public class CountyState
    {
        public int CountyId { get; set; }
        public string CountyName { get; set; }
        public int CountyPopulation { get; set; }
        public int? CountyTotalTests { get; set; }
        public int? CountyTotalConfirmedCases { get; set; }
        public int? CountyTotalDeaths { get; set; }
        public int StateId { get; set; }
        public string StateName { get; set; }
        public int StatePopulation { get; set; }
        public int? StateTotalTests { get; set; }
        public int? StateTotalConfirmedCases { get; set; }
        public int? StateTotalDeaths { get; set; }
    }
}


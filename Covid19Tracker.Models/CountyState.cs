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
        public double? CountyTotalTests { get; set; }
        public double? CountyTotalConfirmedCases { get; set; }
        public double? CountyTotalDeaths { get; set; }
        public double? CoutyFatalityRate { get; set; }
        public double? CountyPositivePercentage { get; set; }
        public int StateId { get; set; }
        public string StateName { get; set; }
        public int StatePopulation { get; set; }
        public int? StateTotalTests { get; set; }
        public double? StateTotalConfirmedCases { get; set; }
        public double? StateTotalDeaths { get; set; }
        public double? StateFatalityRate { get; set; }
        public double? StatePositivePercentage { get; set; }
    }
}


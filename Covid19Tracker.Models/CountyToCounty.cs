using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Models
{
    public class CountyToCounty
    {
        public int CountyId { get; set; }
        public string CountyName { get; set; }
        public int CountyPopulation { get; set; }
        public double? CountyTotalTests { get; set; }
        public double? CountyTotalConfirmedCases { get; set; }
        public double? CountyTotalDeaths { get; set; }
        public double? CoutyFatalityRate { get; set; }
        public double? CountyPositivePercentage { get; set; }

        public int SecondCountyId { get; set; }
        public string SecondCountyName { get; set; }
        public int SecondCountyPopulation { get; set; }
        public double? SecondCountyTotalTests { get; set; }
        public double? SecondCountyTotalConfirmedCases { get; set; }
        public double? SecondCountyTotalDeaths { get; set; }
        public double? SecondCoutyFatalityRate { get; set; }
        public double? SecondCountyPositivePercentage { get; set; }
    }
}

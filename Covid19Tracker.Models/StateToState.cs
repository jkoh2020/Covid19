using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Models
{
   public class StateToState
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public int StatePopulation { get; set; }
        public int? StateTotalTests { get; set; }
        public double? StateTotalConfirmedCases { get; set; }
        public double? StateTotalDeaths { get; set; }
        public double? StateFatalityRate { get; set; }
        public double? StatePositivePercentage { get; set; }

        public int SecondStateId { get; set; }
        public string SecondStateName { get; set; }
        public int SecondStatePopulation { get; set; }
        public int? SecondStateTotalTests { get; set; }
        public double? SecondStateTotalConfirmedCases { get; set; }
        public double? SecondStateTotalDeaths { get; set; }
        public double? SecondStateFatalityRate { get; set; }
        public double? SecondStatePositivePercentage { get; set; }
    }
}

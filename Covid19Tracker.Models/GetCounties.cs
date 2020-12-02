using Covid19Tracker.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Models
{
    public class GetCounties
    {

        [Key]
        public int CountyId { get; set; }
        public string CountyName { get; set; }
        public int Population { get; set; }   
        public List<GetCountiesData> CountyData {get; set; }
        //public virtual List<CountyData> CountyData { get; set; }
        public int? TotalTests { get; set; }
        public int? TotalConfirmedCases { get; set; }
        public int? TotalDeaths { get; set; }



    }
}

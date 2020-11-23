using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Data
{
    public class CountyData
    {
        
        [Key]
        public int DataId { get; set; }
        public DateTime Date {get;set;}
        public int TodayTests{get;set;}
        public int TodayConfirmedCases { get; set; }
        public int TodayDeaths { get; set; }
        public int CountyId { get; set; }
        public int RecordId { get; set; }
        public Guid UserId { get; set; }
        public int TotalTests { get; set; }
        
        
        //[ForeignKey(nameof(CountyId))]
        //public virtual County County { get; set; }
    }
}

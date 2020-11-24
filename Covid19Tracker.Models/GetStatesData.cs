using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Models
{
    public class GetStatesData
    {
        public int DataId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public int StateId { get; set; }
        public int TodayTests { get; set; }
        public int TodayConfirmedCases { get; set; }
        public int TodayDeaths { get; set; }
    }
}

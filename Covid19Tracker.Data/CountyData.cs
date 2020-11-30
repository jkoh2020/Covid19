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
        public Guid UserId { get; set; }


		//public int TotalTests { get; set; }
		//public int TotalConfirmedCases { get; set; }
		//public int TotalDeaths { get; set; }

		//public int TotalTests { get; set; }
		// public virtual List<County> County { get; set; }


		//[ForeignKey(nameof(CountyId))]
		//public virtual County County { get; set; }

		//      // Backing fields
		//      private int _TotalTests;
		//      private int _TotalConfirmedCases;
		//      private int _TotalDeaths;

		//      public int TotalTests
		//      {
		//          get
		//          {
		//              return TodayTests += 10000;
		//          }
		//          set
		//	{
		//		_TotalTests = value;
		//	}
		//}
		//      public int TotalConfirmedCases
		//      {
		//          get
		//          {
		//              return TodayConfirmedCases += 10000;
		//          }
		//          set
		//	{
		//		_TotalConfirmedCases = value;
		//	}
		//}
		//      public int TotalDeaths
		//      {
		//          get
		//          {
		//              return TodayDeaths += 10000;
		//          }
		//          set
		//	{
		//		_TotalDeaths = value;
		//	}
		//}
	}
}

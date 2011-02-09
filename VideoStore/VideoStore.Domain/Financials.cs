using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoStore.Contracts;
using System.Threading;

namespace VideoStore.Domain
{
	public class Financials : IStatistics
	{
		public decimal GetAverageRentalsForYear(int year)
		{
			// Demo Code
			Thread.Sleep(year * 10);
			return new Random(year).Next(0, 1000);
		}


		public void RateService(StarRating rating)
		{
			// do something with the rating here.
		}
	}
}

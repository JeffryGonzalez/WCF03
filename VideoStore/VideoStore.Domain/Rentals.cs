using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoStore.Contracts;
using System.Threading;

namespace VideoStore.Domain
{
	public class Rentals : IRentalReturns
	{
		public void RegisterForNotificationOnReturn(int videoId)
		{
			throw new NotImplementedException();
		}
	}

	public class ReturnWatcher
	{
		public IRentalReturnsCallback Callback = null;

		public ReturnWatcher(IRentalReturnsCallback callback)
		{
			this.Callback = callback;
		}

		public void WatchThisItem(int videoId)
		{
			var r = new Random();
			for(int x =0; x<20; x++)
			{
				Thread.Sleep(r.Next(1,3) * 1000);
				Callback.VideoReturned(videoId,DateTime.Now);
			}
		}
	}
}

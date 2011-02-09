using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoStore.Contracts;
using System.Threading;
using System.ServiceModel;

namespace VideoStore.Domain
{
	public class Rentals : IRentalReturns
	{
		public void RegisterForNotificationOnReturn(int videoId)
		{
			// a little hokey here.
			var returnWatcher = new ReturnWatcher(OperationContext.Current.GetCallbackChannel<IRentalReturnsCallback>(),videoId);

			var workerThread = new Thread(new ThreadStart(returnWatcher.WatchThisItem));
			workerThread.IsBackground = true;
			workerThread.Start();

		}
	}

	public class ReturnWatcher
	{
		public IRentalReturnsCallback Callback = null;
		private int videoId;
		public ReturnWatcher(IRentalReturnsCallback callback, int videoId)
		{
			this.Callback = callback;
			this.videoId = videoId;
		}

		public void WatchThisItem()
		{
			var r = new Random();
			Thread.Sleep(5000); // Wait 5 seconds then start.
			for(int x =0; x<5; x++)
			{
				Thread.Sleep(r.Next(1,3) * 1000);
				Callback.VideoReturned(videoId,DateTime.Now);
			}
		}
	}
}

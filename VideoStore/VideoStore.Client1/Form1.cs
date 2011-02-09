using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using VideoStore.Client1.svc;
using System.ServiceModel;

namespace VideoStore.Client1
{
	public partial class Form1 : Form, rentalsService.IRentalReturnsCallback
	{
		private static StatisticsClient asyncService;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnSynch_Click(object sender, EventArgs e)
		{
			var service = new svc.StatisticsClient();
			MessageBox.Show(service.GetAverageRentalsForYear(1999).ToString());
		}

		private void btnAsynch_Click(object sender, EventArgs e)
		{
			var service = new svc.StatisticsClient();
			service.GetAverageRentalsForYearCompleted += new EventHandler<VideoStore.Client1.svc.GetAverageRentalsForYearCompletedEventArgs>(service_GetAverageRentalsForYearCompleted);
			service.GetAverageRentalsForYearAsync(1999);
		}

		void service_GetAverageRentalsForYearCompleted(object sender, VideoStore.Client1.svc.GetAverageRentalsForYearCompletedEventArgs e)
		{
			MessageBox.Show(e.Result.ToString());
		}

		private void btnAsynch2_Click(object sender, EventArgs e)
		{
			asyncService = new svc.StatisticsClient();
		
			var ar = asyncService.BeginGetAverageRentalsForYear(1999, AllDone,null);
			btnAsynch2.BackColor = Color.Black;
			for(var t = 0; t< 256; t+= 50)
			{
				btnAsynch2.BackColor = Color.FromArgb(t, t, t);
				Application.DoEvents();
				
				Thread.Sleep(200);
			}
		
		}

		private static void AllDone(IAsyncResult ar)
		{
			var answer = asyncService.EndGetAverageRentalsForYear(ar);
			MessageBox.Show(answer.ToString());

		}

		private void btnRating_Click(object sender, EventArgs e)
		{
			var service = new svc.StatisticsClient();
			service.RateService(StarRating.Four);
		}

		private void btnRegisterForDuplex_Click(object sender, EventArgs e)
		{
			var context = new InstanceContext(this);
			var service = new rentalsService.RentalReturnsClient(context);
			service.RegisterForNotificationOnReturn(99);
		}

		public void VideoReturned(int videoId, DateTime when)
		{
			// need a method invoker here - but ok for a demo.
			lstUpdates.Items.Add(string.Format("Video {0} Returned at {1:T}", videoId, when));
		}
	}
}

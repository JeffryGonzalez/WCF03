using System;
using System.ServiceModel.Description;
using System.ServiceModel;
using VideoStore.Domain;
using VideoStore.Contracts;

namespace VideoStore.Host
{
	class Program
	{
		static void Main(string[] args)
		{
			var host = new ServiceHost(typeof (Financials));
			var address = "net.pipe://localhost/VideoStore/";
			host.AddServiceEndpoint(typeof (IStatistics), new NetNamedPipeBinding(), address);
			var mexBehavior = new ServiceMetadataBehavior();
			mexBehavior.HttpGetEnabled = true;
			mexBehavior.HttpGetUrl = new Uri("http://localhost:8080/VideoStore/MEX");
			host.Description.Behaviors.Add(mexBehavior);
			host.Open();
			Console.WriteLine("--- Service Running --- Hit Enter To Close ---");
			Console.ReadLine();
			host.Close();
			
		}
	}
}

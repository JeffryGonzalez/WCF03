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
			var financialsHost = HostFinancials();
			var rentalHost = HostRentals();
			financialsHost.Open();
			rentalHost.Open();
			Console.WriteLine("--- Service Running --- Hit Enter To Close ---");
			Console.ReadLine();
			financialsHost.Close();
			rentalHost.Close();

		}

		private static ServiceHost HostRentals()
		{
			var svc = Host(typeof (Rentals), typeof (IRentalReturns), "net.pipe://localhost/VideoStore/Rentals");
			var mexAddress = new Uri("http://localhost:8080/VideoStore/Rentals/MEX");
			AddMex(mexAddress, svc);
			return svc;
		}

		private static ServiceHost HostFinancials()
		{
			var svc = Host(typeof(Financials), typeof(IStatistics), "net.pipe://localhost/VideoStore/");
			var mexAddress = new Uri("http://localhost:8080/VideoStore/MEX");

			AddMex(mexAddress, svc);

			return svc;
		}

		private static void AddMex(Uri mexAddress, ServiceHost svc)
		{
			var mexBehavior = new ServiceMetadataBehavior();
			mexBehavior.HttpGetEnabled = true;
			mexBehavior.HttpGetUrl = mexAddress;
			svc.Description.Behaviors.Add(mexBehavior);
		}

		private static ServiceHost Host(Type serviceType, Type contract, string address)
		{
			var host = new ServiceHost(serviceType);
			host.AddServiceEndpoint(contract, new NetNamedPipeBinding(), address);
			return host;

		}
	}
}

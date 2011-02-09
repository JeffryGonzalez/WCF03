using System.ServiceModel;
using System;
namespace VideoStore.Contracts
{
	[ServiceContract(CallbackContract = typeof(IRentalReturnsCallback))]
	public interface IRentalReturns
	{
		[OperationContract(IsOneWay = true)]
		void RegisterForNotificationOnReturn(int videoId);

	}

	[ServiceContract]
	public interface IRentalReturnsCallback
	{
		[OperationContract(IsOneWay = true)]
		void VideoReturned(int videoId, DateTime when);
	}
}
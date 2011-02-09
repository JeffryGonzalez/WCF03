using System.ServiceModel;
namespace VideoStore.Contracts
{
	[ServiceContract]
	public interface IStatistics
	{
		[OperationContract]
		decimal GetAverageRentalsForYear(int year);

	}
}
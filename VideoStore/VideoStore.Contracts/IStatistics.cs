using System.ServiceModel;
namespace VideoStore.Contracts
{
	[ServiceContract]
	public interface IStatistics
	{
	
		[OperationContract]
		decimal GetAverageRentalsForYear(int year);

		[OperationContract(IsOneWay = true)]
		void RateService(StarRating rating);
	}
		public enum StarRating
		{
			One,
			Two,
			Three,
			Four,
			Five
		} ;
}
using Azure;
using Repository.AzureTables;

namespace Repository.Tests
{
	public class Account : Entity
	{
		public string? RowKey { get; set; }
		public DateTimeOffset? Timestamp { get; set; }
		public string? Email { get; set; }
        public int Age { get; set; }
        public string? PartitionKey { get; set; }
		public ETag ETag { get; set; }
	}
}

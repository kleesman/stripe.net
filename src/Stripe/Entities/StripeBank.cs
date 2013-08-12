using Newtonsoft.Json;

namespace Stripe
{
	public class StripeBank
	{
        [JsonProperty("bank_name")]
		public string Name { get; set; }

		[JsonProperty("last4")]
		public string Last4 { get; set; }

		[JsonProperty("country")]
		public string Type { get; set; }
        
        [JsonProperty("fingerprint")]
		public string Fingerprint { get; set; }
	}
}
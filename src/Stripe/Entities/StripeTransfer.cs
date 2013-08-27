using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeTransfer
	{
		[JsonProperty("id")]
		public string Id { get; set; }

    [JsonProperty("livemode")]
    public bool? LiveMode { get; set; }

    [JsonProperty("amount")]
    public int? AmountInCents { get; set; }

    [JsonProperty("currency")]
    public string Currency { get; set; }

    [JsonProperty("date")]
    [JsonConverter(typeof(StripeDateTimeConverter))]
    public DateTime? Date { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("balance_transaction")]
    public string BalanceTransaction { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("recipient")]
    public string Recipient { get; set; }

    [JsonProperty("statement_descriptor")]
    public string StatementDescriptor { get; set; }

    [JsonProperty("account")]
		public StripeBank StripeBank { get; set; }
	}
}
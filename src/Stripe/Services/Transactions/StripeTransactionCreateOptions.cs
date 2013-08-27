using System;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeTransactionCreateOptions
	{

    [JsonProperty("amount")]
    public int? AmountInCents { get; set; }

    [JsonProperty("currency")]
    public string Currency { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("recipient")]
    public string Recipient { get; set; }

    [JsonProperty("statement_descriptor")]
    public string StatementDescriptor { get; set; }
   
  }
}

﻿using Newtonsoft.Json;
namespace Stripe
{
	public class StripeChargeCreateOptions : CreditCardOptions
	{
		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		[JsonProperty("application_fee")]
		public int? ApplicationFeeInCents { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

    [JsonProperty("statement_description")]
    public string StatementDescription { get; set; }

		[JsonProperty("customer")]
		public string CustomerId { get; set; }

		[JsonProperty("capture")]
		public bool? Capture { get; set; }
	}
}
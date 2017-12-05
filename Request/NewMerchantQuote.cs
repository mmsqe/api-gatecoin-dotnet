using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Merchant/Payment/Quote", "POST", Summary = @"Request a quote for quick order", Notes = @"")]
public class NewMerchantQuote : IReturn<MerchantQuoteResponse>
{
[ApiMember(Name = "Label", Description = "Label", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Label {get; set; } 
[ApiMember(Name = "CurrencyTo", Description = "Request for quote to currency, Ex: USD, HKD, EUR", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String CurrencyTo {get; set; } 
[ApiMember(Name = "Amount", Description = "Amount expressed in the currency From if not specified", ParameterType = "body", DataType = "decimal", IsRequired = true)]
public System.Decimal Amount {get; set; } 
[ApiMember(Name = "IsAmountInCurrencyFrom", Description = "If true, convert xxx amount of BTC to CurrencyTo. If false, convert xxx amount of CurrencyTo to BTC ", ParameterType = "body", DataType = "bool", IsRequired = false)]
public Boolean IsAmountInCurrencyFrom {get; set; } 
[ApiMember(Name = "Reference", Description = "Reference number. for slock.it token sale, this is the contract address", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Reference {get; set; } 
[ApiMember(Name = "ExtraData", Description = "for slock.it token sale, this is the data for the contract", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ExtraData {get; set; } 
}
}


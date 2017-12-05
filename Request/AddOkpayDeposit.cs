using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Okpay/DepositRequest", "POST", Summary = @"Deposit fiat currency through Okpay", Notes = @"")]
public class AddOkpayDeposit : IReturn<OkpayTransactionResponse>
{
[ApiMember(Name = "Currency", Description = "Currency to deposit", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Currency {get; set; } 
[ApiMember(Name = "Amount", Description = "Deposit amount", ParameterType = "body", DataType = "decimal", IsRequired = true)]
public System.Decimal Amount {get; set; } 
}
}


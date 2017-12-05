using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Okpay/Withdrawal", "POST", Summary = @"Withdraw flat currency through Okpay", Notes = @"")]
public class AddOkpayWithdrawal : IReturn<OkpayTransactionResponse>
{
[ApiMember(Name = "Currency", Description = "Currency to withdraw", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Currency {get; set; } 
[ApiMember(Name = "Amount", Description = "Withdrawal amount", ParameterType = "body", DataType = "decimal", IsRequired = true)]
public System.Decimal Amount {get; set; } 
[ApiMember(Name = "WalletId", Description = "OkPay Wallet Id", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String WalletId {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}


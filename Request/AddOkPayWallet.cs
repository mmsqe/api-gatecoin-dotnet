using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Okpay/Wallet", "POST", Summary = @"Add a new wallet", Notes = @"")]
public class AddOkPayWallet : IReturn<OkpayTransactionResponse>
{
[ApiMember(Name = "WalletId", Description = "Wallet Address", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String WalletId {get; set; } 
[ApiMember(Name = "Label", Description = "Wallet Label", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Label {get; set; } 
[ApiMember(Name = "Password", Description = "Require password confirm to add okaypay wallet", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Password {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}


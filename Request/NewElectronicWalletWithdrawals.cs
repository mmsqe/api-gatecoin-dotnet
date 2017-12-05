using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/Withdrawals/{DigiCurrency}", "POST", Summary = @"Request a transfer from the traders account to an external address. This is only available for crypto currencies.", Notes = @"")]
public class NewElectronicWalletWithdrawals : IReturn<CommonResponse>
{
[ApiMember(Name = "DigiCurrency", Description = "The digital currency to withdraw", ParameterType = "path", DataType = "string", IsRequired = true)]
public System.String DigiCurrency {get; set; } 
[ApiMember(Name = "AddressName", Description = "External address name", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String AddressName {get; set; } 
[ApiMember(Name = "Amount", Description = "Amount to withdraw", ParameterType = "body", DataType = "decimal", IsRequired = true)]
public System.Decimal Amount {get; set; } 
[ApiMember(Name = "Comment", Description = "comment", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Comment {get; set; } 
[ApiMember(Name = "ExtraInfo", Description = "", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ExtraInfo {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}


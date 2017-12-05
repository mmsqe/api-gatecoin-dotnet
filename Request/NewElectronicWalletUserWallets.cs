using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/UserWallets/{DigiCurrency}", "POST", Summary = @"Add an external digital currency addresses to the logged in user. ", Notes = @"")]
public class NewElectronicWalletUserWallets : IReturn<CommonResponse>
{
[ApiMember(Name = "DigiCurrency", Description = "Crypto-currency for the address (btc,ltc etc)", ParameterType = "path", DataType = "string", IsRequired = true)]
public System.String DigiCurrency {get; set; } 
[ApiMember(Name = "AddressName", Description = "Address Name", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String AddressName {get; set; } 
[ApiMember(Name = "Address", Description = "Public address of wallet", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Address {get; set; } 
[ApiMember(Name = "Password", Description = "Require password confirm to add external address", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Password {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}


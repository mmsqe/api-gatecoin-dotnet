using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Okpay/Wallet/{Label}", "DELETE", Summary = @"Deletes an existing wallet", Notes = @"")]
public class DeleteOkPayWallet : IReturn<CommonResponse>
{
[ApiMember(Name = "Label", Description = "Existing Wallet Label", ParameterType = "path", DataType = "string", IsRequired = true)]
public System.String Label {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}


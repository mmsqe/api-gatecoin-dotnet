using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Merchant/Gateway", "PUT", Summary = @"Update the settings of default gateway", Notes = @"")]
public class UpdateDefaultMerchantGateway : IReturn<CommonResponse>
{
[ApiMember(Name = "Webhook", Description = "Webhook url", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Webhook {get; set; } 
[ApiMember(Name = "ExpirySecond", Description = "Seconds before expiry", ParameterType = "body", DataType = "int", IsRequired = false)]
public Int32 ExpirySecond {get; set; } 
}
}


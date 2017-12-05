using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/DisableGoogleAuth", "POST", Summary = @"Disable google auth", Notes = @"")]
public class DisableGoogleAuth : IReturn<CommonResponse>
{
[ApiMember(Name = "Password", Description = "Require password confirmation to disable google auth", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Password {get; set; } 
[ApiMember(Name = "AuthCode", Description = "The code shown on authentication device", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String AuthCode {get; set; } 
}
}


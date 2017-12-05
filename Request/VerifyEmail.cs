using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/Email/Verify", "POST", Summary = @"Verification email", Notes = @"")]
public class VerifyEmail : IReturn<CommonResponse>
{
[ApiMember(Name = "Token", Description = "Token for verification", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Token {get; set; } 
}
}


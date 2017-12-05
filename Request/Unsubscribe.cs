using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Public/Unsubscribe/{EmailCode}", "POST", Summary = @"Lets the user unsubscribe from emails", Notes = @"")]
public class Unsubscribe : IReturn<CommonResponse>
{
[ApiMember(Name = "EmailCode", Description = "Email template code", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String EmailCode {get; set; } 
[ApiMember(Name = "Email", Description = "Email id of the user", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Email {get; set; } 
}
}


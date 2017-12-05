using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Auth/ForgotPassword", "POST", Summary = @"Request reset password", Notes = @"")]
public class ForgotPassword : IReturn<CommonResponse>
{
[ApiMember(Name = "UserID", Description = "User ID", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String UserID {get; set; } 
[ApiMember(Name = "Email", Description = "Registration email", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Email {get; set; } 
}
}


using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Auth/Login", "POST", Summary = @"Trader session log in.", Notes = @"")]
public class Login : IReturn<LoginResponse>
{
[ApiMember(Name = "UserName", Description = "user name / email", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String UserName {get; set; } 
[ApiMember(Name = "Password", Description = "password", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Password {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
[ApiMember(Name = "CaptchaResponse", Description = "Captcha code", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String CaptchaResponse {get; set; }
}
}


using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Public/Contact", "POST", Summary = @"Post a contact", Notes = @"Implementation notes...")]
public class RecaptchaPost : IReturn<CommonResponse>
{
[ApiMember(Name = "Subject", Description = "Subject", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Subject {get; set; } 
[ApiMember(Name = "Name", Description = "Name", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Name {get; set; } 
[ApiMember(Name = "Email", Description = "Email", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Email {get; set; } 
[ApiMember(Name = "Message", Description = "Message that will be reflected on the Get", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Message {get; set; } 
[ApiMember(Name = "Response", Description = "Response code", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Response {get; set; } 
}
}


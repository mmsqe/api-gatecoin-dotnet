using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Ping", "POST", Summary = @"Post a string, then get it back.", Notes = @"Implementation notes...")]
public class PingPost : IReturn<PingResponse>
{
[ApiMember(Name = "Message", Description = "Message that will be reflected on the Get", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Message {get; set; } 
}
}


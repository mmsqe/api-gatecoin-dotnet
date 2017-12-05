using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/Level", "POST", Summary = @"Request verif level of logged in user", Notes = @"")]
public class RequestVerifLevel : IReturn<CommonResponse>
{
[ApiMember(Name = "Level", Description = "Verif Level", ParameterType = "body", DataType = "int", IsRequired = false)]
public Int32 Level {get; set; } 
}
}


using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Bank/UserAccounts", "PUT", Summary = @"Update the label of existing user bank accounnt", Notes = @"")]
public class UpdateUserAccount : IReturn<CommonResponse>
{
[ApiMember(Name = "Currency", Description = "Currency of the bank account", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Currency {get; set; } 
[ApiMember(Name = "Label", Description = "Existing Label", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Label {get; set; } 
[ApiMember(Name = "NewLabel", Description = "New Bank Label", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String NewLabel {get; set; } 
}
}


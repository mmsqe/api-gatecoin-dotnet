using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/ReferredCode", "PUT", Summary = @"Update referral code", Notes = @"")]
public class PutReferredCode : IReturn<CommonResponse>
{
[ApiMember(Name = "ReferralCode", Description = "The referral code of user who recommend you to use gatecoin", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ReferralCode {get; set; } 
}
}


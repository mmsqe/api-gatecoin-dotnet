using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Bank/Transactions", "POST", Summary = @"Request a transfer from the traders account of the logged in user. This is only available for bank account", Notes = @"The account transfer needs to be approved.")]
public class AddBankAccountWithdraw : IReturn<CommonResponse>
{
[ApiMember(Name = "BankAccountName", Description = "Nick of bank account", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String BankAccountName {get; set; } 
[ApiMember(Name = "Currency", Description = "Withdraw currency", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Currency {get; set; } 
[ApiMember(Name = "Amount", Description = "Withdraw amount", ParameterType = "body", DataType = "decimal", IsRequired = true)]
public System.Decimal Amount {get; set; } 
[ApiMember(Name = "Comment", Description = "Withdraw Comment", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Comment {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}


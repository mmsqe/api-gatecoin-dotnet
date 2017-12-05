using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/Ledger", "POST", Summary = @"Request to order ledger", Notes = @"")]
public class AddRequestLedger : IReturn<CommonResponse>
{
[ApiMember(Name = "SingleAmount", Description = "The amount of single ledgers request", ParameterType = "body", DataType = "int", IsRequired = false)]
public Int32 singleAmount {get; set; } 
[ApiMember(Name = "DuoAmount", Description = "The amount of duo ledgers request", ParameterType = "body", DataType = "int", IsRequired = false)]
public Int32 duoAmount {get; set; } 
[ApiMember(Name = "ShippingFee", Description = "shipping fee", ParameterType = "body", DataType = "decimal", IsRequired = true)]
public System.Decimal shippingFee {get; set; } 
[ApiMember(Name = "FamilyName", Description = "FamilyName", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String FamilyName {get; set; } 
[ApiMember(Name = "Line1", Description = "Address line 1", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String line1 {get; set; } 
[ApiMember(Name = "Line2", Description = "Address line 2", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String line2 {get; set; } 
[ApiMember(Name = "City", Description = "City", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String City {get; set; } 
[ApiMember(Name = "Country", Description = "Country of residence", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Country {get; set; } 
[ApiMember(Name = "ZIP", Description = "Zip/Postal Code", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ZIP {get; set; } 
}
}


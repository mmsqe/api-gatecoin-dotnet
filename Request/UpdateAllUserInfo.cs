using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/User", "PUT", Summary = @"Update all user info", Notes = @"")]
public class UpdateAllUserInfo : IReturn<CommonResponse>
{
[ApiMember(Name = "FamilyName", Description = "Family Name", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String FamilyName {get; set; } 
[ApiMember(Name = "GivenName", Description = "Given Name", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String GivenName {get; set; } 
[ApiMember(Name = "Alias", Description = "Alias", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Alias {get; set; } 
[ApiMember(Name = "HomePhone", Description = "Home phone", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String HomePhone {get; set; } 
[ApiMember(Name = "BusinessPhone", Description = "Business Phone", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String BusinessPhone {get; set; } 
[ApiMember(Name = "MobilePhone", Description = "Mobile Phone", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String MobilePhone {get; set; } 
[ApiMember(Name = "Email", Description = "Email", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Email {get; set; } 
[ApiMember(Name = "Email2", Description = "2nd Email", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Email2 {get; set; } 
[ApiMember(Name = "Line1", Description = "Address line 1", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Line1 {get; set; } 
[ApiMember(Name = "Line2", Description = "Address line 2", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Line2 {get; set; } 
[ApiMember(Name = "City", Description = "City", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String City {get; set; } 
[ApiMember(Name = "State", Description = "State/Province", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String State {get; set; } 
[ApiMember(Name = "CountryCode", Description = "Country of residence", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String CountryCode {get; set; } 
[ApiMember(Name = "ZIP", Description = "Zip/Postal Code", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ZIP {get; set; } 
[ApiMember(Name = "Citiznship", Description = "Citizenship", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Citiznship {get; set; } 
[ApiMember(Name = "Birthday", Description = "Birthday", ParameterType = "body", DataType = "datetime", IsRequired = false)]
public System.DateTime? Birthday {get; set; } 
[ApiMember(Name = "BirthPlace", Description = "Birth Place", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String BirthPlace {get; set; } 
[ApiMember(Name = "Gender", Description = "Gender (M/F)", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Gender {get; set; } 
[ApiMember(Name = "CurrentStatus", Description = "Current employment status", ParameterType = "body", DataType = "int", IsRequired = false)]
public Int32 CurrentStatus {get; set; } 
[ApiMember(Name = "SourceOfIncome", Description = "Source of income", ParameterType = "body", DataType = "int", IsRequired = false)]
public Int32 SourceOfIncome {get; set; } 
[ApiMember(Name = "NatureOfBusiness", Description = "Nature of business", ParameterType = "body", DataType = "int", IsRequired = false)]
public Int32 NatureOfBusiness {get; set; } 
[ApiMember(Name = "Employer", Description = "Employer", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Employer {get; set; } 
[ApiMember(Name = "TotalAnnualIncome", Description = "Total annual income", ParameterType = "body", DataType = "int", IsRequired = false)]
public Int32 TotalAnnualIncome {get; set; } 
[ApiMember(Name = "LiquidNetWorth", Description = "Liquid net worth", ParameterType = "body", DataType = "int", IsRequired = false)]
public Int32 LiquidNetWorth {get; set; } 
[ApiMember(Name = "TotalNetWorth", Description = "Total net worth", ParameterType = "body", DataType = "int", IsRequired = false)]
public Int32 TotalNetWorth {get; set; } 
[ApiMember(Name = "Password", Description = "Require password confirm to change names", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Password {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}


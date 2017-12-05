using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/User", "POST", Summary = @"Submit all account info", Notes = @"")]
public class SubmitAll : IReturn<CommonResponse>
{
[ApiMember(Name = "ReferralCode", Description = "The referral code of user who recommend you to use gatecoin", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ReferralCode {get; set; } 
[ApiMember(Name = "GivenName", Description = "Given name", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String GivenName {get; set; } 
[ApiMember(Name = "FamilyName", Description = "Family Name", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String FamilyName {get; set; } 
[ApiMember(Name = "Birthday", Description = "Birthday", ParameterType = "body", DataType = "datetime", IsRequired = true)]
public System.DateTime? Birthday {get; set; } 
[ApiMember(Name = "Nationality", Description = "Nationality", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Nationality {get; set; } 
[ApiMember(Name = "HomePhone", Description = "Home Phone", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String HomePhone {get; set; } 
[ApiMember(Name = "MobilePhone", Description = "Mobile Phone", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String MobilePhone {get; set; } 
[ApiMember(Name = "Line1", Description = "Address line 1", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String Line1 {get; set; } 
[ApiMember(Name = "Line2", Description = "Address line 2", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Line2 {get; set; } 
[ApiMember(Name = "City", Description = "City", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String City {get; set; } 
[ApiMember(Name = "State", Description = "State/Province", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String State {get; set; } 
[ApiMember(Name = "ZIP", Description = "ZIP", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String ZIP {get; set; } 
[ApiMember(Name = "CountryCode", Description = "Country of residence", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String CountryCode {get; set; } 
[ApiMember(Name = "IDDocumentNumber", Description = "IDDocumentNumber", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String IDDocumentNumber {get; set; } 
[ApiMember(Name = "IDIssuingCountry", Description = "IDIssuingCountry", ParameterType = "body", DataType = "string", IsRequired = true)]
public System.String IDIssuingCountry {get; set; } 
[ApiMember(Name = "IDMimeType", Description = "The mime type of the id document", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String IDMimeType {get; set; } 
[ApiMember(Name = "IDContent", Description = "File content in base64 of id document", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String IDContent {get; set; } 
[ApiMember(Name = "ProofMimeType", Description = "The mime type of the proof document", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ProofMimeType {get; set; } 
[ApiMember(Name = "ProofContent", Description = "File content in base64 of proof document", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String ProofContent {get; set; } 
[ApiMember(Name = "SecurityQuestion", Description = "SecurityQuestion", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String SecurityQuestion {get; set; } 
[ApiMember(Name = "SecurityAnswer", Description = "SecurityAnswer", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String SecurityAnswer {get; set; } 
[ApiMember(Name = "LoginWarning", Description = "Receive email warning for login", ParameterType = "body", DataType = "bool", IsRequired = true)]
public Boolean LoginWarning {get; set; } 
[ApiMember(Name = "LoginValidation", Description = "Require validation for login (none = 0, 1 = email, 2 = google auth, 3 = sms)", ParameterType = "body", DataType = "int", IsRequired = true)]
public Int32 LoginValidation {get; set; } 
[ApiMember(Name = "TradeWarning", Description = "Receive email warning for trade", ParameterType = "body", DataType = "bool", IsRequired = true)]
public Boolean TradeWarning {get; set; } 
[ApiMember(Name = "TradeValidation", Description = "Require validation for trade (none = 0, 1 = email, 2 = google auth, 3 = sms)", ParameterType = "body", DataType = "int", IsRequired = true)]
public Int32 TradeValidation {get; set; } 
[ApiMember(Name = "WithdrawWarning", Description = "WithdrawWarning", ParameterType = "body", DataType = "bool", IsRequired = true)]
public Boolean WithdrawWarning {get; set; } 
[ApiMember(Name = "WithdrawValidation", Description = "Require validation for withdraw (none = 0, 1 = email, 2 = google auth, 3 = sms)", ParameterType = "body", DataType = "int", IsRequired = true)]
public Int32 WithdrawValidation {get; set; } 
[ApiMember(Name = "AddAccountWarning", Description = "AddAccountWarning", ParameterType = "body", DataType = "bool", IsRequired = true)]
public Boolean AddAccountWarning {get; set; } 
[ApiMember(Name = "AddAccountValidation", Description = "Require validation for adding bank account and external electronic address (none = 0, 1 = email, 2 = google auth, 3 = sms)", ParameterType = "body", DataType = "int", IsRequired = true)]
public Int32 AddAccountValidation {get; set; } 
[ApiMember(Name = "ChangeDetailsWarning", Description = "ChangeDetailsWarning", ParameterType = "body", DataType = "bool", IsRequired = true)]
public Boolean ChangeDetailsWarning {get; set; } 
[ApiMember(Name = "ChangeDetailsValidation", Description = "Require validation for changing details (none = 0, 1 = email, 2 = google auth, 3 = sms)", ParameterType = "body", DataType = "int", IsRequired = true)]
public Int32 ChangeDetailsValidation {get; set; } 
[ApiMember(Name = "ChangePasswordValidation", Description = "Require validation for changing password (none = 0, 1 = email, 2 = google auth, 3 = sms)", ParameterType = "body", DataType = "int", IsRequired = true)]
public Int32 ChangePasswordValidation {get; set; } 
[ApiMember(Name = "IsGoogleAuthEnabled", Description = "Enabled Google Auth", ParameterType = "body", DataType = "bool", IsRequired = true)]
public Boolean IsGoogleAuthEnabled {get; set; } 
}
}


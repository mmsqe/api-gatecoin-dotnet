using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/DocumentID", "POST", Summary = @"Upload ID document copy", Notes = @"")]
public class Document_ID : IReturn<CommonResponse>
{
[ApiMember(Name = "DocumentNumber", Description = "Document number of the uploaded document", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String DocumentNumber {get; set; } 
[ApiMember(Name = "IssuingCountry", Description = "Issuing country of the uploaded document", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String IssuingCountry {get; set; } 
[ApiMember(Name = "MimeType", Description = "The mime type of the document", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String MimeType {get; set; } 
[ApiMember(Name = "Content", Description = "File content in base64", ParameterType = "body", DataType = "string", IsRequired = false)]
public System.String Content {get; set; } 
}
}


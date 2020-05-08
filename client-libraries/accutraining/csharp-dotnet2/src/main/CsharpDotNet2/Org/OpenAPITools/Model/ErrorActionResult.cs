using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Object returned when the action execution failed
  /// </summary>
  [DataContract]
  public class ErrorActionResult {
    /// <summary>
    /// Specifies if the execution of the action was successful
    /// </summary>
    /// <value>Specifies if the execution of the action was successful</value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// Message with context information about the response
    /// </summary>
    /// <value>Message with context information about the response</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Error flag that describes the error in the execution
    /// </summary>
    /// <value>Error flag that describes the error in the execution</value>
    [DataMember(Name="error_flag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_flag")]
    public string ErrorFlag { get; set; }

    /// <summary>
    /// Contains the domain of the account where the action was applied on
    /// </summary>
    /// <value>Contains the domain of the account where the action was applied on</value>
    [DataMember(Name="domain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "domain")]
    public string Domain { get; set; }

    /// <summary>
    /// Contains the url to redirect to when an error is found during the execution of the action
    /// </summary>
    /// <value>Contains the url to redirect to when an error is found during the execution of the action</value>
    [DataMember(Name="redirect_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirect_url")]
    public string RedirectUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ErrorActionResult {\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  ErrorFlag: ").Append(ErrorFlag).Append("\n");
      sb.Append("  Domain: ").Append(Domain).Append("\n");
      sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}

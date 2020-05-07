using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Default action result
  /// </summary>
  [DataContract]
  public class ActionResult {
    /// <summary>
    /// Specifies if the execution of the action was successful
    /// </summary>
    /// <value>Specifies if the execution of the action was successful</value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// Objects returned by the action
    /// </summary>
    /// <value>Objects returned by the action</value>
    [DataMember(Name="results", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "results")]
    public List<Object> Results { get; set; }

    /// <summary>
    /// Message with context information about the response
    /// </summary>
    /// <value>Message with context information about the response</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionResult {\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  Results: ").Append(Results).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
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

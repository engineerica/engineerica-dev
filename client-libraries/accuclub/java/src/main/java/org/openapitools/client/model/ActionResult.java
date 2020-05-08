/*
 * AccuCampus OpenAPI 3 Documentation
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 * Default action result
 */
@ApiModel(description = "Default action result")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2020-05-08T15:19:57.881190-04:00[America/New_York]")
public class ActionResult {
  public static final String SERIALIZED_NAME_SUCCESS = "success";
  @SerializedName(SERIALIZED_NAME_SUCCESS)
  private Boolean success;

  public static final String SERIALIZED_NAME_RESULTS = "results";
  @SerializedName(SERIALIZED_NAME_RESULTS)
  private List<Object> results = null;

  public static final String SERIALIZED_NAME_MESSAGE = "message";
  @SerializedName(SERIALIZED_NAME_MESSAGE)
  private String message;


  public ActionResult success(Boolean success) {
    
    this.success = success;
    return this;
  }

   /**
   * Specifies if the execution of the action was successful
   * @return success
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Specifies if the execution of the action was successful")

  public Boolean getSuccess() {
    return success;
  }


  public void setSuccess(Boolean success) {
    this.success = success;
  }


  public ActionResult results(List<Object> results) {
    
    this.results = results;
    return this;
  }

  public ActionResult addResultsItem(Object resultsItem) {
    if (this.results == null) {
      this.results = new ArrayList<Object>();
    }
    this.results.add(resultsItem);
    return this;
  }

   /**
   * Objects returned by the action
   * @return results
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Objects returned by the action")

  public List<Object> getResults() {
    return results;
  }


  public void setResults(List<Object> results) {
    this.results = results;
  }


  public ActionResult message(String message) {
    
    this.message = message;
    return this;
  }

   /**
   * Message with context information about the response
   * @return message
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Message with context information about the response")

  public String getMessage() {
    return message;
  }


  public void setMessage(String message) {
    this.message = message;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ActionResult actionResult = (ActionResult) o;
    return Objects.equals(this.success, actionResult.success) &&
        Objects.equals(this.results, actionResult.results) &&
        Objects.equals(this.message, actionResult.message);
  }

  @Override
  public int hashCode() {
    return Objects.hash(success, results, message);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ActionResult {\n");
    sb.append("    success: ").append(toIndentedString(success)).append("\n");
    sb.append("    results: ").append(toIndentedString(results)).append("\n");
    sb.append("    message: ").append(toIndentedString(message)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}


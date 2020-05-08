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

/**
 * Object returned when the action execution failed
 */
@ApiModel(description = "Object returned when the action execution failed")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2020-05-08T15:19:57.881190-04:00[America/New_York]")
public class ErrorActionResult {
  public static final String SERIALIZED_NAME_SUCCESS = "success";
  @SerializedName(SERIALIZED_NAME_SUCCESS)
  private Boolean success;

  public static final String SERIALIZED_NAME_MESSAGE = "message";
  @SerializedName(SERIALIZED_NAME_MESSAGE)
  private String message;

  public static final String SERIALIZED_NAME_ERROR_FLAG = "error_flag";
  @SerializedName(SERIALIZED_NAME_ERROR_FLAG)
  private String errorFlag;

  public static final String SERIALIZED_NAME_DOMAIN = "domain";
  @SerializedName(SERIALIZED_NAME_DOMAIN)
  private String domain;

  public static final String SERIALIZED_NAME_REDIRECT_URL = "redirect_url";
  @SerializedName(SERIALIZED_NAME_REDIRECT_URL)
  private String redirectUrl;


  public ErrorActionResult success(Boolean success) {
    
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


  public ErrorActionResult message(String message) {
    
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


  public ErrorActionResult errorFlag(String errorFlag) {
    
    this.errorFlag = errorFlag;
    return this;
  }

   /**
   * Error flag that describes the error in the execution
   * @return errorFlag
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Error flag that describes the error in the execution")

  public String getErrorFlag() {
    return errorFlag;
  }


  public void setErrorFlag(String errorFlag) {
    this.errorFlag = errorFlag;
  }


  public ErrorActionResult domain(String domain) {
    
    this.domain = domain;
    return this;
  }

   /**
   * Contains the domain of the account where the action was applied on
   * @return domain
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Contains the domain of the account where the action was applied on")

  public String getDomain() {
    return domain;
  }


  public void setDomain(String domain) {
    this.domain = domain;
  }


  public ErrorActionResult redirectUrl(String redirectUrl) {
    
    this.redirectUrl = redirectUrl;
    return this;
  }

   /**
   * Contains the url to redirect to when an error is found during the execution of the action
   * @return redirectUrl
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Contains the url to redirect to when an error is found during the execution of the action")

  public String getRedirectUrl() {
    return redirectUrl;
  }


  public void setRedirectUrl(String redirectUrl) {
    this.redirectUrl = redirectUrl;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ErrorActionResult errorActionResult = (ErrorActionResult) o;
    return Objects.equals(this.success, errorActionResult.success) &&
        Objects.equals(this.message, errorActionResult.message) &&
        Objects.equals(this.errorFlag, errorActionResult.errorFlag) &&
        Objects.equals(this.domain, errorActionResult.domain) &&
        Objects.equals(this.redirectUrl, errorActionResult.redirectUrl);
  }

  @Override
  public int hashCode() {
    return Objects.hash(success, message, errorFlag, domain, redirectUrl);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ErrorActionResult {\n");
    sb.append("    success: ").append(toIndentedString(success)).append("\n");
    sb.append("    message: ").append(toIndentedString(message)).append("\n");
    sb.append("    errorFlag: ").append(toIndentedString(errorFlag)).append("\n");
    sb.append("    domain: ").append(toIndentedString(domain)).append("\n");
    sb.append("    redirectUrl: ").append(toIndentedString(redirectUrl)).append("\n");
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

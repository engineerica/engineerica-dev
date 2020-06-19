# ActionlogApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionlogList**](ActionlogApi.md#actionlogList) | **GET** /actionlog/list | View a list of users action logs


<a name="actionlogList"></a>
# **actionlogList**
> actionlogList(from, count, user, startdate, enddate, resource, actionfilter, argument)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ActionlogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ActionlogApi apiInstance = new ActionlogApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    UUID user = new UUID(); // UUID | The id of the user whose action logs have to be returned.
    OffsetDateTime startdate = new OffsetDateTime(); // OffsetDateTime | The start date of the period to filter the logs.
    OffsetDateTime enddate = new OffsetDateTime(); // OffsetDateTime | The end date of the period to filter the logs.
    String resource = "resource_example"; // String | The resource to filter the action logs.
    String actionfilter = "actionfilter_example"; // String | The action to filter the action logs.
    String argument = "argument_example"; // String | The id of the entity that was the argument of the executed action.
    try {
      apiInstance.actionlogList(from, count, user, startdate, enddate, resource, actionfilter, argument);
    } catch (ApiException e) {
      System.err.println("Exception when calling ActionlogApi#actionlogList");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |
 **user** | [**UUID**](.md)| The id of the user whose action logs have to be returned. | [optional]
 **startdate** | **OffsetDateTime**| The start date of the period to filter the logs. | [optional]
 **enddate** | **OffsetDateTime**| The end date of the period to filter the logs. | [optional]
 **resource** | **String**| The resource to filter the action logs. | [optional]
 **actionfilter** | **String**| The action to filter the action logs. | [optional]
 **argument** | **String**| The id of the entity that was the argument of the executed action. | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

